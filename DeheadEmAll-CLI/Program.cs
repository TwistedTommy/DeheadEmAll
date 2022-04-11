using System.Threading;
using System.Threading.Tasks;
using Serilog;
using Serilog.Formatting.Display;
using Serilog.Sinks.LogEmAll;

namespace DeheadEmAll_CLI
{
    /// <summary>
    /// The Main Program Class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The Main entry point for the program.
        /// </summary>
        static void Main(string[] args)
        {
            // Configure the Logger.
            ConfigureSerilog();

            // Create a new program object.
            DeheadEmAll.DeheadEmAll DHEA = new DeheadEmAll.DeheadEmAll();

            // Set the title.
            DHEA.UpdateTitle();

            // Print the version.
            DHEA.PrintVersion();

            // Load the options passed from the command line arguments.
            DHEA.LoadOptionsFromCLI(args);

            // Load the options passed from the default options file.
            DHEA.LoadOptionsFromFile();

            // Process the command switch.
            DHEA.ProcessCommandSwitch();

            // Output the log to a text file.
            DHEA.SaveLogToFile();
        }

        /// <summary>
        /// Configure the logger.
        /// </summary>
        public static void ConfigureSerilog()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console(outputTemplate: "{Level:u4}: {Message:lj}{NewLine}{Exception}")
                .WriteToListString(new MessageTemplateTextFormatter("{Level:u4}: {Message:lj}{Exception}"))
                .CreateLogger();
        }
    }
}
