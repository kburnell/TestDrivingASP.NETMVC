using System;

namespace TestDrivingMVC.Common.Interfaces.Service {

    public interface ILoggingService {

        void LogInfo(string infoMessage);
        void LogDebug(string debugMessage);
        void LogWarning(string warningMessage);
        void LogError(Exception ex);
        void LogError(Exception ex, string errorMessage);

    }

}