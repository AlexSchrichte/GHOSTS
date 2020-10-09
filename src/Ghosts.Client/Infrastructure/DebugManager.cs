﻿using System;
using System.IO;
using Ghosts.Domain.Code;

namespace Ghosts.Client.Infrastructure
{
    internal static class DebugManager
    {
        public static void Evaluate()
        {
            DebugManager.Debug();
            if (Program.IsDebug)
            {
                Debug();
            }
            else
            {
                Console.WriteLine(
                    $"GHOSTS ({ApplicationDetails.Name}:{ApplicationDetails.Version}) running in production mode. Installed path: {ApplicationDetails.InstalledPath}");
            }
        }

        private static void Debug()
        {
            Console.WriteLine($"GHOSTS ({ApplicationDetails.Name}:{ApplicationDetails.Version}) running in debug mode. Installed path: {ApplicationDetails.InstalledPath}");
            Console.WriteLine($"{ApplicationDetails.ConfigurationFiles.Application} == {File.Exists(ApplicationDetails.ConfigurationFiles.Application)}");
            Console.WriteLine($"{ClientConfigurationResolver.Dictionary} == {File.Exists(ClientConfigurationResolver.Dictionary)}");
            Console.WriteLine($"{ClientConfigurationResolver.EmailContent} == {File.Exists(ClientConfigurationResolver.EmailContent)}");
            Console.WriteLine($"{ClientConfigurationResolver.EmailReply} == {File.Exists(ClientConfigurationResolver.EmailReply)}");
            Console.WriteLine($"{ClientConfigurationResolver.EmailDomain} == {File.Exists(ClientConfigurationResolver.EmailDomain)}");
            Console.WriteLine($"{ClientConfigurationResolver.EmailOutside} == {File.Exists(ClientConfigurationResolver.EmailOutside)}");
            Console.WriteLine($"{ApplicationDetails.ConfigurationFiles.Health} == {File.Exists(ApplicationDetails.ConfigurationFiles.Health)}");
            Console.WriteLine($"{ApplicationDetails.ConfigurationFiles.Timeline} == {File.Exists(ApplicationDetails.ConfigurationFiles.Timeline)}");

            Console.WriteLine($"{ApplicationDetails.InstanceFiles.Id} == {File.Exists(ApplicationDetails.InstanceFiles.Id)}");
            Console.WriteLine($"{ApplicationDetails.InstanceFiles.FilesCreated} == {File.Exists(ApplicationDetails.InstanceFiles.FilesCreated)}");
            Console.WriteLine($"{ApplicationDetails.InstanceFiles.SurveyResults} == {File.Exists(ApplicationDetails.InstanceFiles.SurveyResults)}");

            Console.WriteLine($"{ApplicationDetails.LogFiles.ClientUpdates} == {File.Exists(ApplicationDetails.LogFiles.ClientUpdates)}");
        }
    }
}
