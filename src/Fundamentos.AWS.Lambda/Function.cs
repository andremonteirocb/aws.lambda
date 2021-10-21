using System;
using Amazon.Lambda.Core;
using AWS.Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Lambda
{
    public class Function
    {
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public Output Handler(Input input, ILambdaContext context)
        {
            var aws_region = Environment.GetEnvironmentVariable("AWS_REGION");
            var aws_param = Environment.GetEnvironmentVariable("AWS_PARAM_TEST");

            return new Output() 
            {
                Result = input.Message.ToUpper(),
                Region = aws_region,
                Params = aws_param
            };
        }
    }
}
