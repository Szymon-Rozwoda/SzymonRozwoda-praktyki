using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Invaders.View;
using Invaders.Model;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Threading;
using System.Windows;



namespace Invaders.ViewModel
{
    class InvadersViewModel : INotifyPropertyChanged
    {
        private readonly ObservableCollection<FrameworkElement> _sprites = new ObservableCollection<FrameworkElement>();
        private readonly ObservableCollection<object> _lives = new ObservableCollection<object>();
        private readonly InvaderModel _model = new InvaderModel();
        private readonly DispatcherTimer _timer = new DispatcherTimer();
        private FrameworkElement _playerControl = null;
        private bool _isPlayerFlashing = false;
        private bool _isLastPaused = true;
        private DateTime? _leftAction = null;
        private DateTime? _rightAction = null;
        private readonly Dictionary<Invader, FrameworkElement> _invaders = new Dictionary<Invader, FrameworkElement>();
        private readonly Dictionary<FrameworkElement, DateTime> _shotInvaders = new Dictionary<FrameworkElement, DateTime>();
        private readonly Dictionary<Shot, FrameworkElement> _shots = new Dictionary<Shot, FrameworkElement>();
        private readonly Dictionary<Point, FrameworkElement> _stars = new Dictionary<Point, FrameworkElement>();
        private readonly List<FrameworkElement> _scanLines = new List<FrameworkElement>();

        public InvadersViewModel()
        {
            Scale = 1;
            _model.ShipChanged += ModelShipChangedEventHandler;
            _model.ShotMoved += ModelShotMovedEventHandler;
            _model.StarChanged += ModeStarChangedEventHandler;

            
        }
    }
}
