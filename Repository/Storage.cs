namespace Description.Repository
{
    public static class Storage
    {
        public static AdminStorage AdminStorage { get; } = new AdminStorage();
        public static ApplicationStorage ApplicationStorage { get; } = new ApplicationStorage();
        public static ArtistStorage ArtistStorage { get; } = new ArtistStorage();
        public static AuthorStorage AuthorStorage { get; } = new AuthorStorage();
        public static BillStorage BillStorage { get; } = new BillStorage();
        public static ClientStorage ClientStorage { get; } = new ClientStorage();
        public static FavoritesStorage FavoritesStorage { get; } = new FavoritesStorage();
        public static ListeningStorage ListeningStorage { get; } = new ListeningStorage();
        public static MusicChartStorage MusicChartStorage { get; } = new MusicChartStorage();
        public static SongStorage SongStorage { get; } = new SongStorage();
        public static StatisticStorage StatisticStorage { get; } = new StatisticStorage();
        public static SubscriptionStorage SubscriptionStorage { get; } = new SubscriptionStorage();

    }
}