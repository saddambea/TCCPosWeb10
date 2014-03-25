/*  Author: Bernardo M. Muller
 *  Date: 24/03/2014 
 *  Part of "Multiuser interaction with SignalR", a conclusion work
 *  for obtaining a especialization title
 *  Contact: saddamm@gmail.com
 */

using Microsoft.AspNet.SignalR;

namespace TCCv3
{
    public class ConversaHub : Hub
    {
        public void SendPointInfo(string user, string text, 
                                  string pointX, string pointY)
        {
            Clients.All.receivePointInfo(
                user,
                text,
                pointX,
                pointY
              );
        }

        public void SendLineInfo(string point01X, string point01Y, 
                                 string point02X, string point02Y)
        {
            Clients.All.sendLineInfo(
                point01X,
                point01Y,
                point02X,
                point02Y
            );
        }
    }
}