using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using design_patterns_reference.observer;
using Moq;

namespace design_patterns_reference.tests.observer
{
    [TestClass]
    public class TelevisionTests
    {
        [TestMethod]
        public void RemoteChannelChanged_ShouldStoreHistoryInTelevision()
        {
            var results = new List<int>();
            var television = new Television(results);
            var remote = new TelevisionRemote();
            remote.ChannelChanged += television.ChannelChanged;

            for (var i = 0; i < 10; i++)
            {
                remote.Channel = i;
            }

            Assert.AreEqual(10, results.Count);
        }
    }
}
