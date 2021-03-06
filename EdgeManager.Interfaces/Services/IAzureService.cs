﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EdgeManager.Interfaces.Models;

namespace EdgeManager.Interfaces.Services
{
    public interface IAzureService
    {
        IObservable<JsonCommand> JsonCommands {get;}
        Task<IoTHubInfo[]> GetIoTHubs(bool reload = false);
        Task<IoTDeviceInfo[]> GetIoTDevices(string hubName, bool reload = false);
        Task<IoTModuleIdentityInfo[]> GetIoTModules(string hubName, string deviceId, bool reload = false);
        Task<ModuleTwin> GetIoTModelTwinProperties(string hubName, string deviceId, string moduleId);
        Task<IoTDirectMethodReply> CallMethod(string method, string hubName, string deviceId, string moduleId, DirectMethodPayloadBase payload);
        Task Login(CancellationToken token);
        Task Logout();
        Task<AzureAccountInfo> GetAccount();
        Task CreateNewDevice(string hubName, string newDeviceName);
        Task DeleteSelectedDevice(string hubName, string deviceId);
        Task<bool> CheckCli();
        ICommandHandler ObserveDeviceMessages(string hubName, string deviceId);
        ICommandHandler MonitorDevice(string hubName, string deviceId);
    }
}