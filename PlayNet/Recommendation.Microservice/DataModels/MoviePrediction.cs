using Microsoft.ML.Data;
using System;

namespace Recommendation.Microservice.DataModels
{
    public class MoviePrediction 
    {
       /* [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }
        public float Probability { get; set; }*/
        public float Score { get; set; }
    }
}
