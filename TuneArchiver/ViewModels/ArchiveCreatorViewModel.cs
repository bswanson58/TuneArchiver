using TuneArchiver.Interfaces;

namespace TuneArchiver.ViewModels {
    class ArchiveCreatorViewModel {
        private readonly IDirectoryScanner  mDirectoryScanner;
        private readonly ISetCreator        mSetCreator;
        private readonly IArchiveBuilder    mArchiveBuilder;

        public ArchiveCreatorViewModel( IDirectoryScanner directoryScanner, ISetCreator setCreator, IArchiveBuilder archiveBuilder ) {
            mDirectoryScanner = directoryScanner;
            mSetCreator = setCreator;
            mArchiveBuilder = archiveBuilder;
        }
    }
}
