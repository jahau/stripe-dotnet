namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ReviewServiceTest : BaseStripeTest
    {
        private const string ReviewId = "prv_123";

        private ReviewService service;
        private ReviewApproveOptions approveOptions;
        private ReviewListOptions listOptions;

        public ReviewServiceTest()
        {
            this.service = new ReviewService();

            this.approveOptions = new ReviewApproveOptions
            {
            };

            this.listOptions = new ReviewListOptions
            {
            };
        }

        [Fact]
        public void Approve()
        {
            var review = this.service.Approve(ReviewId, this.approveOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/reviews/prv_123/approve");
            Assert.NotNull(review);
            Assert.Equal("review", review.Object);
        }

        [Fact]
        public async Task ApproveAsync()
        {
            var review = await this.service.ApproveAsync(ReviewId, this.approveOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/reviews/prv_123/approve");
            Assert.NotNull(review);
            Assert.Equal("review", review.Object);
        }

        [Fact]
        public void Get()
        {
            var review = this.service.Get(ReviewId);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews/prv_123");
            Assert.NotNull(review);
            Assert.Equal("review", review.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var review = await this.service.GetAsync(ReviewId);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews/prv_123");
            Assert.NotNull(review);
            Assert.Equal("review", review.Object);
        }

        [Fact]
        public void List()
        {
            var reviews = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews");
            Assert.NotNull(reviews);
            Assert.Equal("list", reviews.Object);
            Assert.Single(reviews.Data);
            Assert.Equal("review", reviews.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var reviews = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews");
            Assert.NotNull(reviews);
            Assert.Equal("list", reviews.Object);
            Assert.Single(reviews.Data);
            Assert.Equal("review", reviews.Data[0].Object);
        }
    }
}
