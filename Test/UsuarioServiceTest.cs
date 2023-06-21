using GeminApi.Domain.models;
using GeminApi.Domain.portsIn;
using GeminApi.Domain.services;
using NSubstitute;
using Test.DataBuilder;

namespace Test
{
    [TestFixture]
    public class UsuarioServiceTest
    {
        private IUnitOfWork _unitOfWork;
        private UsuarioService usuarioService;
        [SetUp]
        public void Setup()
        {
            _unitOfWork = Substitute.For<IUnitOfWork>();
            usuarioService = new UsuarioService(_unitOfWork);
        }

        [Test]
        public void TestCreacionUsuarioSinProblemas()
        {
            //Arrange
            var usuario = new UsuarioBuilder();

            //Action
            var usuarioCreado =  usuarioService.CreateUsuario(usuario);

            //Assert
            Assert.IsNotNull(usuarioCreado.Id);
        }
    }
}