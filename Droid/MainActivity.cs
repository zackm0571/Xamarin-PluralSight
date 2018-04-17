using Android.App;
using Android.Widget;
using Android.OS;
namespace PluralSightTutorial.Droid
{
    [Activity(Label = "PluralSightTutorial", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        private AlbumManager albumManager;
        private int count = 1;
        private TextView albumTitle, albumDescription;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            albumTitle = FindViewById<TextView>(Resource.Id.Title);
            albumDescription = FindViewById<TextView>(Resource.Id.Description);
            // Get our button from the layout resource,
            // and attach an event to it
            Button prevButton = FindViewById<Button>(Resource.Id.prevButton);
            Button nextButton = FindViewById<Button>(Resource.Id.nextButton);

            prevButton.Click +=
                delegate
                {
                    albumManager.MovePrev();
                    updateUI();
                };

            nextButton.Click +=
                delegate
                {
                    albumManager.MoveNext();
                    updateUI();
                };

            albumManager = new AlbumManager();
            albumManager.MoveFirst();
            updateUI();
        }

        private void updateUI()
        {
            Album currentAlbum = albumManager.CurrentAlbum();   
            albumTitle.SetText(currentAlbum.Title.ToString(), TextView.BufferType.Normal);
            albumDescription.SetText(currentAlbum.Artist.ToString(), TextView.BufferType.Normal);
            
        }
    }
}

