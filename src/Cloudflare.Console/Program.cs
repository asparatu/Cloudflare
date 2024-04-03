using Amazon.Runtime;
using Amazon.S3;

namespace Cloudflare.Console;

class Program
{
    private static IAmazonS3? _s3Client;

    public static void Main(string[] args)
    {
        var accessKey = "<ACCESS_KEY>";
        var secretKey = "<SECRET_KEY>";
        var credentials = new BasicAWSCredentials(accessKey, secretKey);
        _s3Client = new AmazonS3Client(credentials, new AmazonS3Config
            {
                ServiceURL = "https://<ACCOUNT_ID>.r2.cloudflarestorage.com",
            });
    }
}  