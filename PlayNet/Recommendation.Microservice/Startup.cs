using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.ML;
using Microsoft.Extensions.Options;
using Recommendation.Microservice.Data;
using Recommendation.Microservice.DataModels;
using Recommendation.Microservice.Helpers;
using Recommendation.Microservice.Model;

namespace Recommendation.Microservice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.Configure<RecommendationDatabaseSettings>(
                Configuration.GetSection(nameof(RecommendationDatabaseSettings)));

            services.AddSingleton<IRecommendationDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<RecommendationDatabaseSettings>>().Value);
            services.AddTransient<IMovieMapRepository, MovieMapRepository>();
            services.AddTransient<IRatingRepository, RatingRepository>();
            services.AddTransient<IPredictionsService, PredictionsService>();

            services.AddPredictionEnginePool<MovieData, MoviePrediction>()
                .FromFile(modelName: "MovieRecommendation", filePath: "ML.Models/MLModel.zip", watchForChanges: true);
            services.AddSwaggerGen();
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rating API V1");
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod()
                .AllowAnyHeader());
        }
    }
}
