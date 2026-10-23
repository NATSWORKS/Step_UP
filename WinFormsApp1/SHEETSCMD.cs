using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class SHEETSCMD
    {
        string clientId = "--";
        string clientSecret = "--";
        string sheetCode = "--";
        int assistencia = 0;
        int compra = 1034986372;
        int fornecedor = 1613736417;
        int log_almoxarifado = 1460795222;
        int montagem = 445856354;
        int produtos = 1129647566;
        int users = 1835626994;

            public void SheetsInsertRow(string sheet, string[] textToSend)
            {
                int sheetIdNum = 0;
                List<object> valuesToCells = new List<object>();
                switch (sheet)
                {
                    case "assistencia":
                        sheetIdNum = assistencia;
                        break;
                    case "compra":
                        sheetIdNum = compra;
                        break;
                    case "fornecedor":
                        sheetIdNum = fornecedor;
                        break;
                    case "log_almoxarifado":
                        sheetIdNum = log_almoxarifado;
                        break;
                    case "montagem":
                        sheetIdNum = montagem;
                        break;
                    case "produtos":
                        sheetIdNum = produtos;
                        break;
                    case "users":
                        sheetIdNum = users;
                        break;
                }
                try
                {
                    string[] Scopes = { SheetsService.Scope.Spreadsheets };
                    var service = new SheetsService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                        {
                            ClientId = clientId,
                            ClientSecret = clientSecret
                        },
                        Scopes, "user", CancellationToken.None, new FileDataStore("MyAppsToken")).Result,
                        ApplicationName = "Google Sheets API .NET Quickstart",
                    });

                    SpreadsheetsResource.ValuesResource.GetRequest getRequest = service.Spreadsheets.Values.Get(sheetCode, sheet + "!A:C");
                    System.Net.ServicePointManager.ServerCertificateValidationCallback =
                        delegate (object sender2, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; };
                    ValueRange getResponse = getRequest.Execute();
                    IList<IList<object>> values = getResponse.Values;

                    for (int x = 1; x < textToSend.Length; x++)
                    {
                        textToSend[x] = "|" + textToSend[x];
                    }
                    InsertDimensionRequest insertRow = new();
                    insertRow.Range = new()
                    {
                        SheetId = sheetIdNum,
                        Dimension = "ROWS",
                        StartIndex = 1,
                        EndIndex = 2
                    };

                    PasteDataRequest data = new()
                    {
                        Data = string.Join("", textToSend),
                        Delimiter = "|",
                        Coordinate = new GridCoordinate
                        {
                            ColumnIndex = 0,
                            RowIndex = 1,
                            SheetId = sheetIdNum
                        },
                    };

                    BatchUpdateSpreadsheetRequest r = new()
                    {
                        Requests = new List<Request>
                        {
                            new Request{ InsertDimension = insertRow },
                            new Request{ PasteData = data }
                        }
                    };

                    BatchUpdateSpreadsheetResponse response1 = service.Spreadsheets.BatchUpdate(r, sheetCode).Execute();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void UpdateRow(string sheet, string index, string[] textToSend)
            {
                int rowIndex = 0;
                int sheetIdNum = 0;
                switch (sheet)
                {
                    case "assistencia":
                        sheetIdNum = assistencia;
                        break;
                    case "compra":
                        sheetIdNum = compra;
                        break;
                    case "fornecedor":
                        sheetIdNum = fornecedor;
                        break;
                    case "log_almoxarifado":
                        sheetIdNum = log_almoxarifado;
                        break;
                    case "montagem":
                        sheetIdNum = montagem;
                        break;
                    case "produtos":
                        sheetIdNum = produtos;
                        break;
                    case "users":
                        sheetIdNum = users;
                        break;
                }
                try
                {
                    string[] Scopes = { SheetsService.Scope.Spreadsheets };
                    var service = new SheetsService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                        {
                            ClientId = clientId,
                            ClientSecret = clientSecret
                        },
                        Scopes, "user", CancellationToken.None, new FileDataStore("MyAppsToken")).Result,
                        ApplicationName = "Google Sheets API .NET Quickstart",
                    });

                    SpreadsheetsResource.ValuesResource.GetRequest getRequest;
                    switch (sheet)
                    {
                        case "assistencia":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "assistencia!A:H");
                            break;
                        case "compra":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "compra!A:J");
                            break;
                        case "fornecedor":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "fornecedor!A:N");
                            break;
                        case "log_almoxarifado":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "log_almoxarifado!A:K");
                            break;
                        case "montagem":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "montagem!A:BB");
                            break;
                        case "produtos":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "produtos!A:L");
                            break;
                        case "users":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "users!A:H");
                            break;
                        default:
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "produtos!A:H");
                            MessageBox.Show("Erro interno, sem referência", "Falha de referência", 0);
                            break;
                    }
                    System.Net.ServicePointManager.ServerCertificateValidationCallback =
                        delegate (object sender2, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; };
                    ValueRange getResponse = getRequest.Execute();
                    IList<IList<object>> values = getResponse.Values;

                    for (int i = 0; i < values.Count; i++)
                    {
                        rowIndex = string.Join(",", values[i][0]) == index ? i : rowIndex;
                    }
                    for (int x = 1; x < textToSend.Length; x++)
                    {
                        textToSend[x] = "|" + textToSend[x];
                    }
                    PasteDataRequest data = new()
                    {
                        Data = string.Join("", textToSend),
                        Delimiter = "|",
                        Coordinate = new GridCoordinate
                        {
                            ColumnIndex = 0,
                            RowIndex = rowIndex,
                            SheetId = sheetIdNum
                        },
                    };

                    BatchUpdateSpreadsheetRequest r = new()
                    {
                        Requests = new List<Request>
                        {
                            new Request{ PasteData = data }
                        }
                    };

                    BatchUpdateSpreadsheetResponse response1 = service.Spreadsheets.BatchUpdate(r, sheetCode).Execute();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void DeleteRow(string sheet, string index)
            {
                int rowIndex = 0;
                int SheetIdNum = 0;
                try
                {
                    string[] Scopes = { SheetsService.Scope.Spreadsheets };
                    var service = new SheetsService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                        {
                            ClientId = clientId,
                            ClientSecret = clientSecret
                        },
                        Scopes, "user", CancellationToken.None, new FileDataStore("MyAppsToken")).Result,
                        ApplicationName = "Google Sheets API .NET Quickstart",
                    });

                    SpreadsheetsResource.ValuesResource.GetRequest getRequest;
                    switch (sheet)
                    {
                        case "assistencia":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "assistencia!A:H");
                            SheetIdNum = assistencia;
                            break;
                        case "compra":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "compra!A:J");
                            SheetIdNum = compra;
                            break;
                        case "fornecedor":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "fornecedor!A:N");
                            SheetIdNum = fornecedor;
                            break;
                        case "log_almoxarifado":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "log_almoxarifado!A:K");
                            SheetIdNum = log_almoxarifado;
                            break;
                        case "montagem":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "montagem!A:BB");
                            SheetIdNum = montagem;
                            break;
                        case "produtos":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "produtos!A:L");
                            SheetIdNum = produtos;
                            break;
                        case "users":
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "users!A:H");
                            SheetIdNum = users;
                            break;
                        default:
                            getRequest = service.Spreadsheets.Values.Get(sheetCode, "produtos!A:H");
                            MessageBox.Show("Erro interno, sem referência", "Falha de referência", 0);
                            break;
                    }
                    System.Net.ServicePointManager.ServerCertificateValidationCallback =
                        delegate (object sender2, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; };
                    ValueRange getResponse = getRequest.Execute();
                    IList<IList<object>> values = getResponse.Values;

                    FindOnSheet(values, index);

                    for (int i = 0; i < values.Count; i++)
                    {
                        rowIndex = string.Join(",", values[i][0]) == index ? i : rowIndex;
                    }
                    DeleteDimensionRequest deleteDimensionRequest = new();
                    deleteDimensionRequest.Range = new()
                    {
                        SheetId = SheetIdNum,
                        Dimension = "ROWS",
                        StartIndex = rowIndex,
                        EndIndex = rowIndex + 1
                    };

                    BatchUpdateSpreadsheetRequest r = new()
                    {
                        Requests = new List<Request>
                        {
                            new Request{ DeleteDimension = deleteDimensionRequest }
                        }
                    };

                    BatchUpdateSpreadsheetResponse response1 = service.Spreadsheets.BatchUpdate(r, sheetCode).Execute();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public BindingSource GenerateTable(string sheet, int columnNumber,string locateTxt = "", string locateColumn = "Código")
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                IList<IList<object>> values;
                string[] Scopes = { SheetsService.Scope.Spreadsheets };
                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                    {
                        ClientId = clientId,
                        ClientSecret = clientSecret
                    },
                    Scopes, "user", CancellationToken.None, new FileDataStore("MyAppsToken")).Result,
                    ApplicationName = "Google Sheets API .NET Quickstart",
                });
                SpreadsheetsResource.ValuesResource.GetRequest getRequest;
                switch (sheet)
                {
                    case "assistencia":
                        getRequest = service.Spreadsheets.Values.Get(sheetCode, "assistencia!A:H");
                        break;
                    case "compra":
                        getRequest = service.Spreadsheets.Values.Get(sheetCode, "compra!A:J");
                        break;
                    case "fornecedor":
                        getRequest = service.Spreadsheets.Values.Get(sheetCode, "fornecedor!A:N");
                        break;
                    case "log_almoxarifado":
                        getRequest = service.Spreadsheets.Values.Get(sheetCode, "log_almoxarifado!A:K");
                        break;
                    case "montagem":
                        getRequest = service.Spreadsheets.Values.Get(sheetCode, "montagem!A:BB");
                        break;
                    case "produtos":
                        getRequest = service.Spreadsheets.Values.Get(sheetCode, "produtos!A:L");
                        break;
                    case "users":
                        getRequest = service.Spreadsheets.Values.Get(sheetCode, "users!A:H");
                        break;
                    default:
                        getRequest = service.Spreadsheets.Values.Get(sheetCode, "produtos!A:H");
                        MessageBox.Show("Erro interno, sem referência", "Falha de referência", 0);
                        break;
                }

                if (getRequest != null)
                {
                    System.Net.ServicePointManager.ServerCertificateValidationCallback =
                    delegate (object sender2, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; };
                    ValueRange getResponse = getRequest.Execute();
                    values = getResponse.Values;
                    for (int i = 0; i < values.Count(); i++)
                    {
                        if (i != 0)
                        {
                            dt.Rows.Add();
                        }
                        for (int x = 0; x < columnNumber; x++)
                        {
                            if (i > 0)
                            {
                                dt.Rows[i - 1][x] = string.Join(",", values[i][x]);
                            }
                            else
                            {
                                dt.Columns.Add(string.Join(",", values[0][x]));
                            }
                        }
                    }
                    for (int y = 0; y < columnNumber; y++)
                    {
                        try
                        {
                            //dt.Columns.Remove("Foto");
                        }
                        catch 
                        {
                            //Nada
                        }
                    }
                    bs.DataSource = dt;
                    if (locateTxt != "")
                    {
                        bs.Filter = locateColumn + " Like '%" + locateTxt + "%'";
                    }
                }
                return bs;
            }

            public int FindOnSheet(IList<IList<object>>? sheet, string index, DataTable? table = null, DataGridView? gridView = null)
            {
                int rowIndex = 0;
                if(sheet != null)
                {
                    for (int i = 0; i < sheet.Count; i++)
                    {
                        rowIndex = string.Join(",", sheet[i][0]) == index ? i : rowIndex;
                    }
                }
                else if(table != null)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        rowIndex = string.Join(",", table.Rows[i][0]) == index ? i : rowIndex;
                    }
                }
                else if (gridView != null)
                {
                    for (int i = 0; i < gridView.Rows.Count; i++)
                    {
                        rowIndex = string.Join(",", gridView.Rows[i].Cells[0]) == index ? i : rowIndex;
                    }
                }
                else
                {
                    MessageBox.Show("Erro: Banco de dados não especificado");
                    return 0;
                }
                return rowIndex;
            }

            //Testes
            public void SendDataToSheets(string textToSend, int oneMore)
            {
                try
                {
                    string[] Scopes = { SheetsService.Scope.Spreadsheets };
                    var service = new SheetsService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                        {
                            ClientId = clientId,
                            ClientSecret = clientSecret
                        },
                        Scopes, "user", CancellationToken.None, new FileDataStore("MyAppsToken")).Result,
                        ApplicationName = "Google Sheets API .NET Quickstart",
                    });

                    SpreadsheetsResource.ValuesResource.GetRequest getRequest = service.Spreadsheets.Values.Get(sheetCode, "dataReceiver!A:C");
                    System.Net.ServicePointManager.ServerCertificateValidationCallback =
                        delegate (object sender2, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; };
                    ValueRange getResponse = getRequest.Execute();
                    IList<IList<object>> values = getResponse.Values;
                    //

                    //Inserir valor em linha
                    /*var Range = $"{"dataReceiver"}!A" + 2 + ":C" + 2;//(values.Count + 1);
                    var ValueRange = new ValueRange();
                    ValueRange.Values = new List<IList<object>> { new List<object>() { textToSend, oneMore } };
                    var updateRequest = service.Spreadsheets.Values.Update(ValueRange, "1aAbRNHJIgjUMeCy0AuJpGDree1-F8OvDbuWAVcyyaZU", Range);
                    updateRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
                    var UpdateResponse = updateRequest.Execute();*/

                    //Inserir linha abaixo
                    /*var ValueRange = new ValueRange();
                    ValueRange.Values = new List<IList<object>> { new List<object>() { textToSend, oneMore } };
                    SpreadsheetsResource.ValuesResource.AppendRequest request = 
                        service.Spreadsheets.Values.Append(ValueRange , "1aAbRNHJIgjUMeCy0AuJpGDree1-F8OvDbuWAVcyyaZU", Range);
                    request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
                    request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
                    var response = request.Execute();*/

                    //Inserir linha e colar
                    InsertDimensionRequest insertRow = new();
                    insertRow.Range = new()
                    {
                        SheetId = assistencia,
                        Dimension = "ROWS",
                        StartIndex = 1,
                        EndIndex = 2
                    };

                    PasteDataRequest data = new()
                    {
                        Data = string.Join(",", textToSend, oneMore),
                        Delimiter = ",",
                        Coordinate = new GridCoordinate
                        {
                            ColumnIndex = 0,
                            RowIndex = 1,
                            SheetId = 1020146920
                        },
                    };

                    BatchUpdateSpreadsheetRequest r = new()
                    {
                        Requests = new List<Request>
                    {
                        new Request{ InsertDimension = insertRow },
                        new Request{ PasteData = data }
                    }
                    };

                    BatchUpdateSpreadsheetResponse response1 = service.Spreadsheets.BatchUpdate(r, sheetCode).Execute();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}
