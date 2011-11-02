namespace DnnClientResourceLogger
{
    using System;
    using System.Web;
    using ClientDependency.Core.Logging;
    using DotNetNuke.Entities.Portals;
    using DotNetNuke.Services.Log.EventLog;

    public class Logger : ILogger
    {
        private static PortalSettings PortalSettings
        {
            get
            {
                return (PortalSettings)HttpContext.Current.Items["PortalSettings"];
            }
        }

        public void Debug(string msg)
        {
            new EventLogController().AddLog("Client Resource: Debug Msg", msg, PortalSettings, -1, EventLogController.EventLogType.ADMIN_ALERT);
        }

        public void Info(string msg)
        {
            new EventLogController().AddLog("Client Resource: Info Msg", msg, PortalSettings, -1, EventLogController.EventLogType.ADMIN_ALERT);
        }

        public void Warn(string msg)
        {
            new EventLogController().AddLog("Client Resource: Warning Msg", msg, PortalSettings, -1, EventLogController.EventLogType.ADMIN_ALERT);
        }

        public void Error(string msg, Exception ex)
        {
            new EventLogController().AddLog("Client Resource: Exception", msg, PortalSettings, -1, EventLogController.EventLogType.ADMIN_ALERT);
            DotNetNuke.Services.Exceptions.Exceptions.LogException(ex);
        }

        public void Fatal(string msg, Exception ex)
        {
            new EventLogController().AddLog("Client Resource: Fatal Exception", msg, PortalSettings, -1, EventLogController.EventLogType.ADMIN_ALERT);
            DotNetNuke.Services.Exceptions.Exceptions.LogException(ex);
        }
    }
}
