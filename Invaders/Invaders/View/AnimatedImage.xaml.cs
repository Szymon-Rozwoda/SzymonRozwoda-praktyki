using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Invaders.View
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl1.xaml
    /// </summary>
    public sealed partial class AnimatedImage : UserControl
    {
        public AnimatedImage()
        {
            this.InitializeComponent();
        }

        public AnimatedImage(IEnumerable<string> imageNames, TimeSpan interval) : this()
        {
            StartAnimation(imageNames, interval);
        }

        public void StartAnimation(IEnumerable<string> imageNames, TimeSpan interval)
        {
            Storyboard storyboard = new Storyboard();
            ObjectAnimationUsingKeyFrames animation = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, image);
            Storyboard.SetTargetProperty(animation, "Source");

            TimeSpan currentInteval = TimeSpan.FromMilliseconds(0);
            foreach (string imageName in imageNames)
            {
                ObjectKeyFrame keyFrame = new DiscreteObjectKeyFrame();
                keyFrame.Value = InvadersHelper.CreateImageFromAssets(imageName);
                keyFrame.KeyTime = currentInteval;
                animation.KeyFrames.Add(keyFrame);
                currentInteval = currentInteval.Add(interval);
            }

            storyboard.RepeatBehavior = RepeatBehavior.Forever;
            storyboard.AutoReverse = true;
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }

        public void InvaderShot()
        {
            invaderShotStoryboard.Begin();
        }

        public void StartFlashing()
        {
            flashStoryboard.Begin();
        }

        public void StopFlashing()
        {
            flashStoryboard.Stop();
        }
    }
}