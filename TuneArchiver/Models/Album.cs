namespace TuneArchiver.Models {
    class Album {
        public  string      Path { get; }
        public  long        Size { get; }

        public Album( string path, long size ) {
            Path = path;
            Size = size;
        }
    }
}
