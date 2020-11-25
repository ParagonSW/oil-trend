# oil-trend

1) Download the repo
2) Open the solution in VS
3) Restore NuGet packages
4) Run

The request is expected to be in raw data format, so if you're using postman make sure to set Content-Type to application/json and send the request as "raw".
This could be an example request: "{ \"id\": 1, \"jsonrpc\": \"2.0\", \"method\": \"GetOilPriceTrend\", \"params\": { \"startDateISO8601\": \"2020-01-01\", \"endDateISO8601\": \"2020-01-05\"}}"
URL: https://localhost:44378/oiltrend
