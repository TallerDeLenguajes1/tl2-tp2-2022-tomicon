using System;
using NLog;

NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
try
{
    Logger.Info("Hello world");
    Logger.Debug("ddddd");
    //System.Console.ReadKey();
}
catch (Exception ex)
{
    Logger.Error(ex, "Goodbye cruel world");
}    
