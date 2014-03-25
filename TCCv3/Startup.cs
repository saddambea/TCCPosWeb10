/*  Author: Bernardo M. Muller
 *  Date: 24/03/2014 
 *  Part of "Multiuser interaction with SignalR", a conclusion work
 *  for obtaining a especialization title
 *  Contact: saddamm@gmail.com
 */

using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TCCv3.Startup))]
namespace TCCv3
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
