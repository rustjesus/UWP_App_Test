﻿using System;
using System.Linq;
using System.Threading.Tasks;

using UWP_App_Test.Core.Services;

using Xunit;

namespace UWP_App_Test.Core.Tests.XUnit
{
    // TODO: Add appropriate unit tests.
    public class Tests
    {
        [Fact]
        public void Test1()
        {
        }

        // Remove or update this once your app is using real data and not the SampleDataService.
        // This test serves only as a demonstration of testing functionality in the Core library.
        [Fact]
        public async Task EnsureSampleDataServiceReturnsContentGridDataAsync()
        {
            var actual = await SampleDataService.GetContentGridDataAsync();

            Assert.NotEmpty(actual);
        }

        // Remove or update this once your app is using real data and not the SampleDataService.
        // This test serves only as a demonstration of testing functionality in the Core library.
        [Fact]
        public async Task EnsureSampleDataServiceReturnsGridDataAsync()
        {
            var actual = await SampleDataService.GetGridDataAsync();

            Assert.NotEmpty(actual);
        }

        // Remove or update this once your app is using real data and not the SampleDataService.
        // This test serves only as a demonstration of testing functionality in the Core library.
        [Fact]
        public async Task EnsureSampleDataServiceReturnsListDetailsDataAsync()
        {
            var actual = await SampleDataService.GetListDetailsDataAsync();

            Assert.NotEmpty(actual);
        }
    }
}
