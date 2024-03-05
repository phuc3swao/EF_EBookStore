namespace eBookStore
{
    public class SessionMiddleware
    {
        private readonly RequestDelegate _next;

        public SessionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path != "/" && !context.Session.TryGetValue("CurrentUser", out byte[] value) && !context.Request.Path.StartsWithSegments("/Auth/Login"))
            {
                // Người dùng chưa đăng nhập, chuyển hướng đến trang đăng nhập
                context.Response.Redirect("/Auth/Login?handler=login");
            }
            else
            {
                await _next(context);
            } 
        }
    }
}
