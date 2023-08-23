using System;
using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    public class MultipartTest
    {
        [Fact]
        public async void UpdateCompanyGreeting()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );
                var account = rc.Restapi().Account();
                var companyAnsweringRuleList = await account.AnsweringRule().List();
                var answeringRule = companyAnsweringRuleList.records.Last();
                // comment out because we don't want to update company greetings
//                var customCompanyGreetingInfo = await account.Greeting().Post(new CreateCompanyGreetingRequest
//                {
//                    type = "Company",
//                    answeringRule = new CustomCompanyGreetingAnsweringRuleInfo
//                    {
//                        id = answeringRule.id
//                    },
//                    binary = new Attachment
//                    {
//                        fileName = "test.mp3",
//                        bytes = File.ReadAllBytes("./test.mp3"),
//                        contentType = "audio/mpeg"
//                    },
//                });

//                var customCompanyGreetingInfo = await account.Greeting().Post(new CreateCompanyGreetingRequest
//                {
//                    type = "Company",
//                    answeringRuleId = answeringRule.id,
//                    binary = new Attachment
//                    {
//                        fileName = "test.mp3",
//                        bytes = File.ReadAllBytes("./test.mp3"),
//                        contentType = "audio/mpeg"
//                    },
//                });
//                Assert.Equal("Company", customCompanyGreetingInfo.type);
            }
        }

        [Fact]
        public async void UpdateUserGreeting()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );
                var extension = rc.Restapi().Account().Extension();
                var userAnsweringRuleList = await extension.AnsweringRule().List();
                var answeringRule = userAnsweringRuleList.records.Last();
                // comment out because we don't want to update user greetings
//                var customGreetingInfo = await extension.Greeting().Post(new CreateCustomUserGreetingRequest
//                {
//                    type = "Voicemail",
//                    answeringRule = new CustomGreetingAnsweringRuleInfoRequest
//                    {
//                        id = answeringRule.id
//                    },
//                    binary = new Attachment
//                    {
//                        fileName = "test.mp3",
//                        bytes = File.ReadAllBytes("./test.mp3"),
//                        contentType = "audio/mpeg"
//                    },
//                });
//                var customGreetingInfo = await extension.Greeting().Post(new CreateUserCustomGreetingRequest
//                {
//                    type = "Voicemail",
//                    answeringRuleId = answeringRule.id,
//                    binary = new Attachment
//                    {
//                        fileName = "test.mp3",
//                        bytes = File.ReadAllBytes("./test.mp3"),
//                        contentType = "audio/mpeg"
//                    },
//                });
//                Assert.Equal("Voicemail", customGreetingInfo.type);
            }
        }
    }
}