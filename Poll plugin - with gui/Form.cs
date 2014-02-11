using System;
using System.Windows.Forms;
using TShockAPI;
using System.Collections.Generic;
using System.Linq;


namespace Poll
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
            
        }
        public static Color PollColor = new Color(14, 205, 95);
        public static Pollitem pollitem = new Pollitem();
        public static  bool PollStarted = false;
        public class Pollitem
        {
            public string question;
            public List<string> answers;
            public List<vote> votes;
            public List<TSPlayer> voters;
            public Pollitem()
            {
                question = null;
                answers = new List<string>();
                votes = new List<vote>();
                voters = new List<TSPlayer>();
            }
        }

        public static void tim_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (PollStarted)
            {
                TSPlayer.All.SendMessage("[Poll repeat] question: " + pollitem.question,PollColor);
                TSPlayer.All.SendMessage("[Poll repeat] valid answers: " + string.Join(", ", pollitem.answers),PollColor);
                TSPlayer.All.SendMessage("[Poll repeat] vote by typing /poll vote <answer>",PollColor);
            }
        }

        public class vote
        {
            public string Name;
            public int Count;
            public vote(string name, int count)
            {
                Name = name;
                Count = count;
            }
        }
        public static void poll(CommandArgs args)
        {
            
            if (args.Parameters.Count < 1)
            {
                if (args.Player.Group.HasPermission("poll.admin"))
                {
                    args.Player.SendErrorMessage("Invalid syntax! proper syntax: /poll <reset/addquestion/addanswer/end/showresult/push/vote/gui>");
                    return;
                }
                else
                {
                    args.Player.SendErrorMessage("Invalid syntax! proper syntax: /poll vote <answer>");
                    return;
                }
            }
            string str = string.Empty;
            switch (args.Parameters[0])
            {
                case "reset":
                    #region reset
                    pollitem = new Pollitem();
                    break;
                    #endregion reset
                case "addquestion":
                    #region addquestion
                    if (args.Parameters.Count < 2)
                    {
                        args.Player.SendErrorMessage("Invalid syntax! valid syntax: /poll addquestion <question>");
                        return;
                    }
                    str = String.Join(" ", args.Parameters.GetRange(1, args.Parameters.Count - 1));
                    pollitem.question = str;
                    args.Player.SendMessage("question set: " + str, PollColor);
                    break;
                    #endregion addquestion
                case "addanswer":
                    #region addanswer
                    if (args.Parameters.Count != 2)
                    {
                        args.Player.SendErrorMessage("Invalid syntax! valid syntax: /poll addanswer <answer>");
                        return;
                    }
                    pollitem.answers.Add(args.Parameters[1].ToLower());
                    args.Player.SendMessage("answer added: " + args.Parameters[1].ToLower(), PollColor);
                    break;
                    #endregion addanswer
                case "start":
                    #region start
                    if (pollitem.question == null)
                    {
                        args.Player.SendErrorMessage("This poll has no question!");
                        return;
                    }
                    if (pollitem.answers.Count < 2)
                    {
                        args.Player.SendErrorMessage("This poll has no answers!");
                        return;
                    }
                    for (int i = 0; i < pollitem.answers.Count; i++)
                    {
                        pollitem.votes.Add(new vote(pollitem.answers[i], 0));
                    }
                    PollStarted = true;
                    TSPlayer.All.SendMessage("[Poll] question: " + pollitem.question, PollColor);
                    TSPlayer.All.SendMessage("[Poll] valid answers: " + string.Join(", ", pollitem.answers), PollColor);
                    TSPlayer.All.SendMessage("[Poll] vote by typing /poll vote <answer>", PollColor);
                    break;
                    #endregion start
                case "vote":
                    #region vote
                    if (args.Parameters.Count != 2)
                    {
                        args.Player.SendErrorMessage("Invalid syntax! valid syntax: /poll vote <answer>");
                        return;
                    }
                    if (!PollStarted)
                    {
                        args.Player.SendErrorMessage("There is no poll running currently!");
                        return;
                    }
                    if (pollitem.voters.Contains(args.Player))
                    {
                        args.Player.SendErrorMessage("You have already voted for this poll!");
                        return;
                    }
                    bool found = false;
                    for (int i = 0; i < pollitem.votes.Count; i++)
                    {

                        if (pollitem.votes[i].Name == args.Parameters[1].ToLower())
                        {
                            pollitem.votes[i].Count++;
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        args.Player.SendErrorMessage("Invalid answer! list of answers: " + string.Join(",", pollitem.answers));
                        return;
                    }
                    pollitem.voters.Add(args.Player);
                    TSPlayer.All.SendMessage(args.Player.Name + " has voted: " + args.Parameters[1], PollColor);
                    args.Player.SendMessage("Thank you for your vote!", PollColor);
                    break;
                    #endregion vote
                case "end":
                    #region end
                    PollStarted = false;
                    TSPlayer.All.SendMessage(args.Player.Name + " has ended the poll!", PollColor);
                    break;
                    #endregion end
                case "showresult":
                    #region showresult
                    if (pollitem.question == null)
                    {
                        args.Player.SendErrorMessage("Nothing to display!");
                        return;
                    }
                    var q = from a in pollitem.votes orderby a.Count select a;
                    List<vote> vtresult = q.ToList();
                    TSPlayer.All.SendMessage("[Poll] Poll results", PollColor);
                    foreach (vote v in vtresult)
                    {
                        TSPlayer.All.SendMessage(v.Name + ": " + v.Count.ToString(), PollColor);
                    }
                    break;
                    #endregion showresult
                case "gui":
                    #region gui
                    Poll.poll.open(args);
                    break;
                default:
                    if (args.Player.Group.HasPermission("poll.admin"))
                        args.Player.SendErrorMessage("Invalid syntax! proper syntax: /poll <reset/addquestion/addanswer/end/showresult/push/vote/gui>");
                   
                    else
                        args.Player.SendErrorMessage("Invalid syntax! proper syntax: /poll vote <answer>");
                    return;
                    #endregion gui
            }
        }

        #region Code for the gui
        private void button1_Click(object sender, EventArgs e) // /poll reset
        {
            timer1.Stop();
            PollStarted = false;
            labelquestion.Text = "";
            textBoxAnswer.Text = "";
            textBoxquestion.Text = "";
            pollitem = new Pollitem();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }


        private void buttonquestion_Click(object sender, EventArgs e) // /poll addquestion
        {
            if (textBoxquestion.Text.Length < 1)
            {
                MessageBox.Show("Please fill in a question!");
            }
            pollitem.question = textBoxquestion.Text;
            labelquestion.Text = textBoxquestion.Text;
        }

        private void buttonanswer_Click(object sender, EventArgs e) // poll addanswer
        {
            if (textBoxAnswer.Text.Length < 1)
            {
                MessageBox.Show("Please fill in an answer!");
                return;
            }
            if (textBoxAnswer.Text.Contains(" "))
            {
                MessageBox.Show("Answer may not contain spaces!");
                return;
            }
            listBox1.Items.Add(textBoxAnswer.Text);
            pollitem.answers.Add(textBoxAnswer.Text);
            labelanswercount.Text = string.Format("Answers ({0}):",listBox1.Items.Count);
        }



        private void button2_Click(object sender, EventArgs e) // /poll push
        {
            if (pollitem.question == null)
            {
                MessageBox.Show("This poll has no question!");
                return;
            }
            if (pollitem.answers.Count < 2)
            {
                MessageBox.Show("This poll has no answers!");
                return;
            }
            for (int i = 0; i < pollitem.answers.Count; i++)
            {
                pollitem.votes.Add(new vote(pollitem.answers[i], 0));
            }
            PollStarted = true;
            timer1.Start();
            TSPlayer.All.SendMessage("[Poll] question: " + pollitem.question, PollColor);
            TSPlayer.All.SendMessage("[Poll] valid answers: " + string.Join(", ", pollitem.answers), PollColor);
            TSPlayer.All.SendMessage("[Poll] vote by typing /poll vote <answer>", PollColor);
        }


        private void button4_Click(object sender, EventArgs e)// /poll end
        {
            timer1.Stop();
            PollStarted = false;
            TSPlayer.All.SendMessage("[Poll] the current poll has ended!", PollColor);
        }



        private void button3_Click(object sender, EventArgs e) // /poll reset
        {
            if (pollitem.question == null)
            {
                MessageBox.Show("Nothing to display!");
                return;
            }
            var q = from a in pollitem.votes orderby a.Count descending select a;
            List<vote> vtresult = q.ToList();
            TSPlayer.All.SendMessage("[Poll] Poll results", PollColor);
            foreach (vote v in vtresult)
            {
                TSPlayer.All.SendMessage(v.Name + ": " + v.Count.ToString(), PollColor);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PollStarted)
            {
                listBox2.Items.Clear();
                var q = from a in pollitem.votes orderby a.Count descending select a;
                List<vote> vtresult = q.ToList();
                foreach (vote v in vtresult)
                {
                    listBox2.Items.Add(string.Format("{0}: {1}", v.Name, v.Count));
                }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (trackBar1.Value * 1000);
            labelinterval.Text = string.Format("Repeat interval in seconds: {0}", (timer1.Interval/1000));
        }

        private void Gui_Load(object sender, EventArgs e)
        {
            trackBar1.Value = 15;
        }
        #endregion code for the gui
    }
}
