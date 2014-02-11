using System;
using Terraria;
using TShockAPI;
using TerrariaApi.Server;
using System.Reflection;
using System.Threading;


namespace Poll
{
    [ApiVersion(1, 14)]
    public class poll : TerrariaPlugin
    {
        public static bool FormOpen = false;
        public override Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }
        public override string Author
        {
            get { return "Ancientgods"; }
        }
        public override string Name
        {
            get { return "Poll"; }
        }
        public override string Description
        {
            get { return "Lets people do polls"; }
        }

        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command(Poll.Gui.poll, "poll"));
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
            base.Dispose(disposing);
        }

        public poll(Main game)
            : base(game)
        {
            Order = 9999999;
        }

        public static void open(CommandArgs args)
        {
            if (args.Player is TShockAPI.TSServerPlayer)
            {
                if (FormOpen)
                {
                    args.Player.SendErrorMessage("Window is already open!");
                    return;
                }
                Thread t = new Thread(() =>
                {
                    
                    Gui f = new Gui();
                    try
                    {
                        FormOpen = true;
                        System.Timers.Timer tim = new System.Timers.Timer(15000);
                        tim.Elapsed += new System.Timers.ElapsedEventHandler(Poll.Gui.tim_Elapsed);
                        f.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        Log.ConsoleError("window closed because it crashed: " + ex.ToString());
                    }
                    TShockAPI.Log.ConsoleInfo("window closed");
                    FormOpen = false;
                });
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else
                args.Player.SendErrorMessage("Only the console can do that.");
        }
    }
}
