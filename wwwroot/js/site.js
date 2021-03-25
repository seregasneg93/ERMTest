const hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/hub")
    .build();

hubConnection.on("NewData", function (freeOfMemory, totalMemory, usageCPU, freeDisks, totalDisks, ip) {
    let td1 = document.createElement("td");
    td1.innerText = ip
    let td2 = document.createElement("td");
    td2.innerText = freeOfMemory + "/" + totalMemory
    let td3 = document.createElement("td");
    td3.innerText = usageCPU
    let td4 = document.createElement("td");
    td4.innerText = freeDisks + "/" + totalDisks

    let tr = document.createElement("tr")
    tr.appendChild(td1)
    tr.appendChild(td2)
    tr.appendChild(td3)
    tr.appendChild(td4)

    let table = document.getElementById("dataTable")
    table.appendChild(tr)
});

function changeDelay() {
    let val = document.getElementById("delayInput").value * 1

    if (val > 0) {
        hubConnection.invoke("ChangeDelay", val)
        alert("Changed")
    }
}

hubConnection.start()