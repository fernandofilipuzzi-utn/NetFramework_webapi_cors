<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueba.aspx.cs" Inherits="Prueba.Cors.NoOrigen.prueba" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test API Call</title>
    <script type="text/javascript">
        function callApi() {
            fetch('https://localhost:44380/api/prueba', {
                method: 'GET',
                headers: {
                    'Content-Type': 'application/json'
                }
            })
            .then(response => {
                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
                return response.json();
            })
            .then(data => {
                document.getElementById('result').innerText = JSON.stringify(data, null, 2);
            })
            .catch(error => {
                document.getElementById('result').innerText = 'Error: ' + error.message;
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Test API Call</h1>
            <button type="button" onclick="callApi()">Call API</button>
            <pre id="result"></pre>
        </div>
    </form>
</body>
</html>