using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace DiscordBot.Modules
{
    public class Invite : ModuleBase<SocketCommandContext>
    {

        [Command("Invite"), RequireUserPermission(GuildPermission.Administrator)]
        [Alias("INVITE", "invite", "inv", "INV")]

        public async Task InviteUserAsync()
        {
            var invite = await Context.Guild.GetInvitesAsync(); //If there are ANY active invites already created, the bot will respond with the latest. 
            await ReplyAsync(invite.Select(x => x.Url).FirstOrDefault());
        }
}
}