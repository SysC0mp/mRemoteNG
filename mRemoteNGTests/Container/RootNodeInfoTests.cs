﻿using mRemoteNG.Connection;
using mRemoteNG.Tree.Root;
using NUnit.Framework;

namespace mRemoteNGTests.Container
{
    public class RootNodeInfoTests
    {
        [Test]
        public void InheritanceIsDisabledForNodesDirectlyUnderRootNode()
        {
            var rootNode = new RootNodeInfo(RootNodeType.Connection);
            var con1 = new ConnectionInfo { Inheritance = { Colors = true } };
            rootNode.AddChild(con1);
            Assert.That(con1.Inheritance.Colors, Is.False);
        }
    }
}
