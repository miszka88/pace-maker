
using Android.App;
using Android.OS;
using Android.Widget;

namespace pace_maker.Droid.Activities
{
    [Activity(Label = "PaceActivity")]
    public class Pace : Activity, SeekBar.IOnSeekBarChangeListener
    {
        SeekBar _seekBar;
        private TextView _textView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            _textView = FindViewById<TextView>(Resource.Id.pace);

            _seekBar.SetOnSeekBarChangeListener(this);
        }

        public void OnProgressChanged(SeekBar seekBar, int progress, bool isFromUser)
        {
            if (isFromUser)
            {
                _textView.Text = string.Format("{0}", seekBar.Progress);
            }
        }

        public void OnStartTrackingTouch(SeekBar seekBar)
        {
            System.Diagnostics.Debug.WriteLine("Tracking changes.");
        }

        public void OnStopTrackingTouch(SeekBar seekBar)
        {
            System.Diagnostics.Debug.WriteLine("Stopped tracking changes.");
        }
    }
}