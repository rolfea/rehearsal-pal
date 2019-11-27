using System;
using rehearsal_pal.Controllers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Xunit;

namespace rehearsal_pal.tests
{
    public class RehearsalControllerFacts
    {
        [Fact]
        public async void RehearsalControllerHappyPath()
        {
          var rehearsalController = new RehearsalController();
          var result = await rehearsalController.GetRehearsal();

          Assert.NotNull(result);

        }
    }
}
