using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.Websocket;
using Microsoft.Extensions.DependencyInjection;

namespace TutorialBot
{

   class Program
   {
     static void Main(string[] args) => new Program().RunBotAsync().GetAwaiter().GetResult();
   }
  
  
  private DiscordSocketClient _client;
  private CommandService _commands;
  private IServiceProvider _service;
  
  
  public async Task RunBotAsync()
  {
    
    _client = new DiscordSocketClient();
    _commands = new CommandService();
    
    _services = new ServiceCollection()
       .addSingleton(_client)
       .AddSingleton(_commands)
       .BuildServiceProvider();
       
       string token = "super-secret-token-xd"
    _client.log += _client_Log;
    
          await RegisterCommandsAsync();
             await _client.LogAsync(TokenType.Bot, token);
             
               await _client.StartAsync();
               
               await Task.Delay(-1);
  }
    
    private Task _client.Log(LogMessage arg)
    {
      Console.WriteLine(arg);
      return Task.CompletedTask;
    }
    
      public async Task RegisterCommandsAsync()
      {
        _client.MessageReceived += HandleCommandAsync;
        await _commands.addModuleAsync(Aszembly.GetEntryAssembly(), _services)
      }
      
      private async Task HandleCommandAsync(SocketMessage args)
      {
        var message = arg as SocketUserMessage;
        var context = new  SocketCommandContext(_client, message);
        if(message.Author.IsBot) return;
        
        if argPos = O;
        if (message.HasStringPrefix("!", ref argPos))
        {
              var result = await _commands.ExecuteAsync(context, argPos, _services)
              if (!result.isSucess) Console.Writeline(result.ErrorReason);
        }
      }
    
  }
