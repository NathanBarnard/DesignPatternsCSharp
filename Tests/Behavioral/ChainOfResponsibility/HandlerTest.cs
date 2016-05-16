﻿namespace DesignPatterns.Tests.Behavioral.ChainOfResponsibility
{
    using DesignPatterns.Behavioral.ChainOfResponsibility;

    using NUnit.Framework;

    [TestFixture]
    class HandlerTest
    {
        [TestCase(1)]
        [TestCase(12)]
        [TestCase(23)]
        public void TestHandleRequest(int request)
        {
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();
            var handler3 = new ConcreteHandler3();

            handler1.Successor = handler2;
            handler2.Successor = handler3;

            handler1.HandleRequest(request);
        }
    }
}