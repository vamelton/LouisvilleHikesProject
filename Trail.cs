namespace LouisvilleHikes
{
    internal class Trail
    {
        private string v;

        public Trail(string v)
        {
            this.v = v;
        }

        public string Distance { get; internal set; }
        public string Difficulty { get; internal set; }
        public string Time { get; internal set; }
        public string Park { get; internal set; }
    }
}