<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HodPage.aspx.cs" Inherits="LAB_05.HodPage" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Admin Panel - User Management</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #f8f9fa;
            padding: 20px;
        }
        .container {
            max-width: 1000px;
        }
        .table {
            background: white;
            box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.2);
            border-radius: 10px;
        }
        .badge {
            font-size: 14px;
            padding: 5px 10px;
        }
        .header {
            background: #28a745;
            color: white;
            padding: 15px;
            text-align: center;
            border-radius: 10px 10px 0 0;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="card">
            <div class="header">
                <h2>User Management</h2>
            </div>
            <div class="p-4">
                <table class="table table-striped table-hover">
                    <thead class="table-success">
                        <tr>
                            <th>User ID</th>
                            <th>Username</th>
                            <th>Access Level</th>
                            <th>Active Status</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptUsers" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("id") %></td>
                                    <td><%# Eval("username") %></td>
                                    <td><%# Eval("access") %></td>
                                    <td><%# Eval("status") %></td>
                                    
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</body>
</html>

