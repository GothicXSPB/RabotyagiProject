﻿using Moq;
using RabotyagiProject.Bll;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotygiProject.Bll.Test.TestCaseSourse;
using NUnit.Framework;

namespace RabotygiProject.Bll.Test
{
    public class ClientManagerTests
    {
        private ClientManager _manager;
        private Mock<IClientRepository> _mock;
        [SetUp]
            public void SetUp()
        {
            _mock = new Mock<IClientRepository>();
            _manager = new ClientManager(_mock.Object);
        }
    }
}
