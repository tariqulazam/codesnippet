public static class WebApiConfig
    {
        #region PUBLIC METHODS

        /// <summary>
        /// The register.
        /// </summary>
        /// <param name="config">
        /// The config.
        /// </param>
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
            config.MessageHandlers.Add(new PreflightRequestHandler());
        }
        
        #endregion
    }
