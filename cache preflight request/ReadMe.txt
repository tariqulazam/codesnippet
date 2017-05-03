In order to cache the preflight request you need to do the following
    1. Create a delegation handler (PreflightRequestHandler.cs)
    2. Register the delegation handler in webapiconfif.cs file.
    
Preflight requests can be cached based on URL (not based on domain) and for a max of 10 minutes (600 seconds) only. For more details please have a look at
http://stackoverflow.com/questions/12013216/how-to-apply-cors-preflight-cache-to-an-entire-domain
