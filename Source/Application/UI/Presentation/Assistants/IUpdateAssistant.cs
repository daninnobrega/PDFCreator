using pdfforge.PDFCreator.UI.Presentation.Assistants.Update;

namespace pdfforge.PDFCreator.UI.Presentation.Assistants
{
    public interface IUpdateAssistant
    {
        ApplicationVersion OnlineVersion { get; }

        bool UpdateProcedureIsRunning { get; }
        bool UpdatesEnabled { get; }

        /// <summary>
        ///     Initialize with NextUpdate and UpdateInterval from Settings
        /// </summary>
        /// <summary>
        ///     Launch UpdateProcedure in separate Thread.
        ///     UpdateManager must be initialized!
        ///     Downloads update-info.txt and compares the recent (online) version to the current version
        ///     and launches assigned events.
        ///     Specific Events must be set in advance.
        ///     Can only be launched once at the time, reported in UpdateProcedureIsRunning flag.
        ///     Resets the UpdateManager afterwards.
        /// </summary>
        /// <param name="checkNecessity"></param>
        void UpdateProcedure(bool checkNecessity);

        bool ShowUpdate { get; }

        void InstallNewUpdate();

        void SkipVersion();

        void SetNewUpdateTime();

        bool IsOnlineUpdateAvailable();

        bool IsUpdateAvailable();
    }
}
