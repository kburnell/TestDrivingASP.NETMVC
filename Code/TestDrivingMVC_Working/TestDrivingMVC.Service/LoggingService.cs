using System;
using TestDrivingMVC.Common.Interfaces.Service;

namespace TestDrivingMVC.Service {

    public class LoggingService : ILoggingService {

        #region ILoggingService Members

        public void LogInfo(string infoMessage) {}

        public void LogDebug(string debugMessage) {}

        public void LogWarning(string warningMessage) {}

        public void LogError(Exception ex) {}

        public void LogError(Exception ex, string errorMessage) {}

        #endregion
    }
}