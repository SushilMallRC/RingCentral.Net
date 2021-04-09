using System;
using Xunit;

namespace RingCentral.Tests
{
    public class CallLogTest
    {
        [Fact]
        public async void GetCallLogs()
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );

                var callLogResponse = await rc.Restapi().Account().CallLog().List(new ReadCompanyCallLogParameters
                {
                    perPage = 3,
                    dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o")
                });
                Assert.Equal(3, callLogResponse.records.Length);
            }
        }

        [Fact]
        public async void FilterByPhoneNumber()
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );

                var callLogResponse = await rc.Restapi().Account().Extension().CallLog().List(
                    new ReadUserCallLogParameters
                    {
                        perPage = 1,
                        dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o")
                    });
                Assert.Single(callLogResponse.records);

                var fromNumber = callLogResponse.records[0].from.phoneNumber;
                callLogResponse = await rc.Restapi().Account().Extension().CallLog().List(new ReadUserCallLogParameters
                {
                    perPage = 1,
                    dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o"),
                    phoneNumber = fromNumber // +123456789
                });
                Assert.Empty(callLogResponse.records);

                callLogResponse = await rc.Restapi().Account().Extension().CallLog().List(new ReadUserCallLogParameters
                {
                    perPage = 1,
                    dateFrom = DateTime.UtcNow.AddMonths(-6).ToString("o"),
                    phoneNumber = fromNumber.TrimStart('+') // 123456789
                });
                Assert.Single(callLogResponse.records);
            }
        }
    }
}