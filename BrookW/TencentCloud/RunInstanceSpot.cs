using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace BrookW.Service
{
    public class RunInstanceSpot
    {
        /// <summary>
        /// 根据设定的模板启动一个实例
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="secretKey"></param>
        /// <param name="launchTemplateId"></param>
        /// <returns></returns>
        public static string[]? RunInstancesByLaunchTemplate(string secretId, string secretKey, string launchTemplateId = "lt-d1jlkcyq")
        {
            try
            {

                Credential cred = new Credential
                {
                    SecretId = secretId,
                    SecretKey = secretKey
                };

                // 实例化要请求产品的client对象,clientProfile是可选的
                CvmClient client = new CvmClient(cred, "ap-singapore");
                // 实例化一个请求对象,每个接口都会对应一个request对象
                RunInstancesRequest req = new RunInstancesRequest();
                req.LaunchTemplate = new LaunchTemplate()
                {
                    LaunchTemplateId = launchTemplateId
                };
                req.InstanceCount = 1;

                // 返回的resp是一个RunInstancesResponse的实例，与请求对象对应
                RunInstancesResponse resp = client.RunInstancesSync(req);
                return resp.InstanceIdSet;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="instanceIds"></param>
        /// <param name="secretId"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        public static string? GetInstancesPublicIp(string[] instanceIds, string secretId, string secretKey)
        {
            var cred = new Credential
            {
                SecretId = secretId,
                SecretKey = secretKey
            };
            CvmClient client = new CvmClient(cred, "ap-singapore");
            // 实例化一个请求对象,每个接口都会对应一个request对象
            DescribeInstancesRequest req = new DescribeInstancesRequest();
            req.InstanceIds = instanceIds;
            // 返回的resp是一个DescribeInstancesResponse的实例，与请求对象对应

            var count = 0;
            while (count++ < 180)
            {
                //等待1000毫秒
                System.Threading.Thread.Sleep(1000);
                try
                {
                    var status = client.DescribeInstancesSync(req);
                    if (status?.InstanceSet?.FirstOrDefault()?.InstanceState?.ToLower() == "running")
                    {
                        return status?.InstanceSet?.FirstOrDefault()?.PublicIpAddresses.FirstOrDefault();
                    }
                    if (!string.IsNullOrEmpty(status?.InstanceSet?.FirstOrDefault()?.LatestOperationErrorMsg))
                    {
                        Console.WriteLine("报错");
                        return string.Empty;
                    }
                }
                catch (Exception)
                {

                }
            }
            return string.Empty;
        }

        /// <summary>
        /// 销毁
        /// </summary>
        /// <param name="instanceIds"></param>
        /// <param name="secretId"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        public static bool TerminateInstances(string[] instanceIds, string secretId, string secretKey)
        {
            Credential cred = new Credential
            {
                SecretId = secretId,
                SecretKey = secretKey
            };
            // 实例化一个client选项，可选的，没有特殊需求可以跳过
            ClientProfile clientProfile = new ClientProfile();
            // 实例化一个http选项，可选的，没有特殊需求可以跳过
            HttpProfile httpProfile = new HttpProfile();
            httpProfile.Endpoint = ("cvm.tencentcloudapi.com");
            clientProfile.HttpProfile = httpProfile;

            // 实例化要请求产品的client对象,clientProfile是可选的
            CvmClient client = new CvmClient(cred, "ap-singapore", clientProfile);
            // 实例化一个请求对象,每个接口都会对应一个request对象
            TerminateInstancesRequest req = new TerminateInstancesRequest();
            req.InstanceIds = instanceIds;
            // 返回的resp是一个TerminateInstancesResponse的实例，与请求对象对应
            TerminateInstancesResponse resp = client.TerminateInstancesSync(req);

            return string.IsNullOrEmpty(resp.RequestId);

        }
    }
}
