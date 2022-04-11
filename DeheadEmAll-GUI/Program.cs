using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;
using Serilog.Formatting.Display;
using Serilog.Sinks.LogEmAll;

namespace DeheadEmAll_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureSerilog();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDeheadEmAll());
        }

        /// <summary>
        /// Configure the logger.
        /// </summary>
        public static void ConfigureSerilog()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteToRichTextBox(new MessageTemplateTextFormatter("{Level:u4}: {Message:lj}{NewLine}{Exception}"))
                .CreateLogger();
        }
    }
}
