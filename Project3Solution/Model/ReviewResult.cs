using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public sealed class ReviewResult
    {
        private double _averageRatingScore;
        private List<Review> _reviews;

        public double AverageReviewScore { get; private set; }

        public IEnumerable<Review> Reviews { get; private set; }

        internal ReviewResult(double averageScore, IEnumerable<Review> reviews)
        {
            this.AverageReviewScore = averageScore;
            this.Reviews = reviews;
        }

        public ReviewResult(double averageRatingScore, List<Review> reviews)
        {
            _averageRatingScore = averageRatingScore;
            _reviews = reviews;
        }
    }

}
