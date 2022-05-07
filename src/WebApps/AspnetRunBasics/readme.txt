https://github.com/aspnetrun/run-aspnetcore-basics


open start up and either config for in-mem db or local db

        public void ConfigureServices(IServiceCollection services)
        {
            #region database services

            //// use in-memory database
            services.AddDbContext<AspnetRunContext>(c =>
                c.UseInMemoryDatabase("AspnetRunConnection"));

            // add database dependecy
            //services.AddDbContext<AspnetRunContext>(c =>
             //   c.UseSqlServer(Configuration.GetConnectionString("AspnetRunConnection")));

            #endregion            

            #region project services

            // add repository dependecy
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();

            #endregion

            services.AddRazorPages();
        }
