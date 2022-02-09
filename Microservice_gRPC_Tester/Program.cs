using Grpc.Net.Client;
using Microservice_gRPC_Tester;

var channel = GrpcChannel.ForAddress(new Uri("https://localhost:7035"));
var client = new DistanceInfo.DistanceInfoClient(channel);
 var response = await
client.GetDistanceAsync(new Cities
{ OriginCity = "Topeka,KS", DestinationCity = "Los Angeles,CA" });
Console.WriteLine(response.Miles);
Console.ReadKey();


