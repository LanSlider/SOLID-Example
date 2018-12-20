namespace D_Valid
{
    public class Music
    {
        public IMusicInstrument MusicInstrument { get; set; }

        public Music(IMusicInstrument musicInstrument)
        {
            this.MusicInstrument = musicInstrument;
        }

        public void PlayMusic()
        {
            MusicInstrument.PlayMusic();
        }
    }
}
