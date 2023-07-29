using JopApplicationLibrary;
using JopApplicationLibrary.Models;
using JopApplicationLibrary.Services;
using Moq;

namespace JobApplicationLibrary.UnitTest
{
    public class ApplicationEvaluateUnitTest
    {
       
            [Test]
            public void Application_ShouldTransferredAutoRecejted_WithUnderAge()
            {

                var mock = new Mock<IIdentityValidator>();
                mock.Setup(i => i.IsValid(It.IsAny<string>())).Returns(true);    

                var evo = new ApplicationEvaluator(mock.Object);
                var form = new JobApplication()
                {
                    Applicant = new Applicant()
                    {
                        Age = 16, // ?
                        IdentityNumber ="" // OK
                    },
                    TechStackList = new() { "C#",".NET","RabbitMQ","Visual Studio" } // OK
                };

               

                var applicationResult = evo.Evaluate(form);



                Assert.AreEqual(ApplicationResult.AutoRejected, applicationResult);

            }

        [Test]
        public void Application_ShouldTransferredAutoRecejted_WithUnderRate()
        {

            var mockValidator = new Mock<IIdentityValidator>();
            mockValidator.Setup(i => i.IsValid(It.IsAny<string>())).Returns(true);

            var evo = new ApplicationEvaluator(mockValidator.Object);
            var form = new JobApplication()
            {
                Applicant = new Applicant()
                {
                    Age = 19,    // OK
                    IdentityNumber = "" // OK
                },
                TechStackList = new() { "" } // ?
                
            };

            var applicationResult = evo.Evaluate(form);



            Assert.AreEqual(ApplicationResult.AutoRejected, applicationResult);

        }

        [Test]
        public void Application_ShouldTransferredToHR_WithUnvalidIdentityNumber()
        {

            var mockValidator = new Mock<IIdentityValidator>();
            mockValidator.Setup(i => i.IsValid(It.IsAny<string>())).Returns(false);

            var evo = new ApplicationEvaluator(mockValidator.Object);
            var form = new JobApplication()
            {
                Applicant = new Applicant()
                {
                    Age = 19, // OK
                    IdentityNumber = "123" // ?
                },
                TechStackList = new() { "C#", ".NET", "RabbitMQ", "Visual Studio" } // OK

            };

            var applicationResult = evo.Evaluate(form);



            Assert.AreEqual(ApplicationResult.TransferredToHR, applicationResult);

        }




    }
}