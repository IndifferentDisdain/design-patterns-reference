using System.Collections.Generic;

namespace design_patterns_reference.observer
{
    public class TelevisionRemote
    {
        public delegate void ChannelChangedDelegate(int newChannel);
        
        public event ChannelChangedDelegate ChannelChanged;
        
        private int _channel;

        public int Channel
        {
            set
            {
                _channel = value;
                ChannelChanged?.Invoke(_channel);
            }
        }
    }

    public class Television
    {
        private readonly IList<int> _channelHistory; 

        public Television(IList<int> channelHistory)
        {
            _channelHistory = channelHistory;
        }

        public void ChannelChanged(int newChannel)
        {
            _channelHistory?.Add(newChannel);
        }
    }
}
