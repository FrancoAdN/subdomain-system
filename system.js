const express = require('express');
const bodyParser = require('body-parser');
const mysql = require('mysql');
const schedule = require('node-schedule');


function checkDate(fech, sum){
    let sp = fech.split('/');
    const days = sp[0] ;
    const month = sp[1] - 1;
    const year = sp[2];
    
    let ant = new Date(year, month, days);
    let date = new Date(year, month, days);
    ant.setDate(date.getDate() + (sum - 1));
    date.setDate(date.getDate() + sum);
    
    
    let today = new Date();


    if(today.toDateString() < date.toDateString())
        return 0;
    else if(today.toDateString() == date.toDateString())
        return 1;
    else if(today.toDateString() == ant.toDateString())
        return 2;
    else
        return null;

}

let notifications = [];

var rule = new schedule.RecurrenceRule();
rule.dayOfWeek = [new schedule.Range(1, 5)];
rule.hour = 10;
rule.minute = 27;

//DATE SCHEDULE
var j = schedule.scheduleJob(rule, function(){

    notifications.length = 0;

    //VENTA DE PRODUCTOS
    let con = connectionSQL();
    let sql =  'SELECT pmde, fecha, orden FROM venta_prod WHERE entregado = false AND Confirmado = true;SELECT pmde, fecha, orden FROM rep_lab WHERE entregado = false AND Confirmado = true;SELECT pmde, fecha, orden FROM ord_nac WHERE entregado = false AND Confirmado = true;SELECT pmde, fecha, orden FROM ord_ext WHERE entregado = false AND Confirmado = true;';
    con.connect(function(err) {
        if (err) {console.error(err);}
        con.query(sql, function (err, result, fields) {
            if (err) { console.error(err);}
            else{
                for(let r of result[0]){
                    let notif = checkDate(r.fecha, r.pmde);
                    console.log(notif);
                    if(notif != null)
                        notifications.push({cod: notif, db: 'venta_prod', orden: r.orden});
                }
                for(let r of result[1]){
                    let notif = checkDate(r.fecha, r.pmde);
                    console.log(notif);
                    if(notif != null)
                        notifications.push({cod: notif, db: 'rep_lab', orden: r.orden});
                }
                for(let r of result[2]){
                    let notif = checkDate(r.fecha, r.pmde);
                    console.log(notif);
                    if(notif != null)
                        notifications.push({cod: notif, db: 'ord_nac', orden: r.orden});
                }
                for(let r of result[3]){
                    let notif = checkDate(r.fecha, r.pmde);
                    console.log(notif);
                    if(notif != null)
                        notifications.push({cod: notif, db: 'ord_ext', orden: r.orden});
                }

            }
          con.end();
        });
    });


    


});


function connectionSQL(){
    const con = mysql.createConnection({
        host: "localhost",
        user: "maxpower_francoadinapoli",
        password: "Fa42904558.;",
        database: "maxpower_subsystem" ,
        multipleStatements: true
    });
    return con;
}
const app = express();

app.use(bodyParser.json({limit:'50mb', extended:true}));

app.use(bodyParser.urlencoded({limit:'50mb', extended:true}));


app.get('/', (req, resp) => {
    resp.send("WELCOME TO THE SYSTEM SERVER OF MAXPOWER INDUSTRIAL AUTOMATION \n\n\n\nTHIS SERVER IS USED TO MAKE REQUESTS");
});

//region ORDEN NACIONAL
app.get('/ord_nac', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `ord_nac` oc INNER JOIN `tabla` t ON oc.orden = t.orden';
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){
          //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_nac;
            let json = {id: result[0].id_nac, emp: result[0].emp, inco: result[0].fdp, mon: result[0].moneda, precio: result[0].precio,
                pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_ext == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_ext;
                    json = {id: result[i].id_ext, emp: result[i].emp, inco: result[i].incoterm, mon: result[i].moneda, precio: result[i].precio,
                        pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
          }else{
              resp.send('9');
          }
          con.end();
        });
    });
});

app.get('/ord_nac/:id', (req, resp) => {
    const orden = req.params.id;
    const sql =  "SELECT * FROM `ord_nac` oc INNER JOIN `tabla` t ON oc.orden = t.orden AND oc.orden = '" + orden + "';";
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){
          //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_nac;
            let json = {id: result[0].id_nac, emp: result[0].emp, inco: result[0].fdp, mon: result[0].moneda, precio: result[0].precio,
                pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_ext == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_ext;
                    json = {id: result[i].id_ext, emp: result[i].emp, inco: result[i].incoterm, mon: result[i].moneda, precio: result[i].precio,
                        pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
          }else{
              resp.send('7');
          }
          con.end();
        });
    });
})

app.get('/ord_nac/emp/:id', (req, resp) => {
    const emp = req.params.id;
    const sql =  "SELECT * FROM `ord_nac` oc INNER JOIN `tabla` t ON oc.orden = t.orden AND oc.emp = '" + emp + "';";
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){
          //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_nac;
            let json = {id: result[0].id_nac, emp: result[0].emp, inco: result[0].fdp, mon: result[0].moneda, precio: result[0].precio,
                pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_ext == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_ext;
                    json = {id: result[i].id_ext, emp: result[i].emp, inco: result[i].incoterm, mon: result[i].moneda, precio: result[i].precio,
                        pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
          }else{
              resp.send('8');
          }
          con.end();
        });
    });
})

app.post('/ord_nac', (req, resp) => {
    const data = req.body;
    const precio = parseInt(data.total.split(' ')[0]);
    data['conf'] = false;
    const nof = parseInt(data.noferta.split('-')[1]);
    let sql =  `INSERT INTO ord_nac (emp, fdp, moneda, precio, pmde, orden, fecha, confirmado) values ('${data.empresa}', '${data.formadepago}', '${data.moneda}', ${precio},'${data.dias}', '${data.noferta}', '${data.fecha}', ${data.conf});
    UPDATE last SET num = ${nof};`;
    for(let t of data.tabla){
        t.cant = parseInt(t.cant);
        t.unit = parseInt(t.unit);
        const ins = `INSERT INTO tabla (cant, descr, punit, orden) VALUES (${t.cant}, '${t.desc}', ${t.unit}, '${data.noferta}');`;
        sql += ins;
    }
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }else
                resp.send("1");
          con.end();
        });
    });

    
})

//end of region

//region ORDEN EXTERIOR
app.get('/ord_ext', (req, resp) => {
    const sql =  'SELECT * FROM `ord_ext` oe INNER JOIN `tabla` t ON oe.orden = t.orden';
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){

            
            //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_ext;
            let json = {id: result[0].id_ext, emp: result[0].emp, inco: result[0].incoterm, mon: result[0].moneda, precio: result[0].precio,
                pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_ext == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_ext;
                    json = {id: result[i].id_ext, emp: result[i].emp, inco: result[i].incoterm, mon: result[i].moneda, precio: result[i].precio,
                        pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
        }else{
            resp.send("9");
        }
          con.end();
        });
    });
});

app.get('/ord_ext/:id', (req, resp) => {
    const orden = req.params.id;
    const sql =  "SELECT * FROM `ord_ext` oe INNER JOIN `tabla` t ON oe.orden = t.orden AND oe.orden = '" + orden + "';";
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){

            
            //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_ext;
            let json = {id: result[0].id_ext, emp: result[0].emp, inco: result[0].incoterm, mon: result[0].moneda, precio: result[0].precio,
                pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_ext == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_ext;
                    json = {id: result[i].id_ext, emp: result[i].emp, inco: result[i].incoterm, mon: result[i].moneda, precio: result[i].precio,
                        pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
        }else{
            resp.send("7");
        }
          con.end();
        });
    });
});

app.get('/ord_ext/emp/:id', (req, resp) => {
    const emp = req.params.id;
    const sql =  "SELECT * FROM `ord_ext` oe INNER JOIN `tabla` t ON oe.orden = t.orden AND oe.emp = '" + emp + "';";
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){

            
            //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_ext;
            let json = {id: result[0].id_ext, emp: result[0].emp, inco: result[0].incoterm, mon: result[0].moneda, precio: result[0].precio,
                pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_ext == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_ext;
                    json = {id: result[i].id_ext, emp: result[i].emp, inco: result[i].incoterm, mon: result[i].moneda, precio: result[i].precio,
                        pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
        }else{
            resp.send("8");
        }
          con.end();
        });
    });
});

app.post('/ord_ext', (req, resp) => {
    const data = req.body;
    const precio = parseInt(data.total.split(' ')[0]);
    data['conf'] = false;
    const nof = parseInt(data.noferta.split('-')[1]);
    let sql =  `INSERT INTO ord_ext (emp, incoterm, moneda, precio, pmde, orden, fecha, confirmado) values ('${data.empresa}', '${data.inco}', '${data.moneda}', ${precio}, '${data.dias}', '${data.noferta}', '${data.fecha}', ${data.conf});
    UPDATE last SET num = ${nof};`;
    for(let t of data.tabla){
        t.cant = parseInt(t.cant);
        t.unit = parseInt(t.unit);
        const ins = `INSERT INTO tabla (cant, descr, punit, orden) VALUES (${t.cant}, '${t.desc}', ${t.unit}, '${data.noferta}');`;
        sql += ins;
    }
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }else
                resp.send("1");
          con.end();
        });
    });

})
//end of region


//region REPARACION DE LABORATORIO

app.get('/rep_lab', (req, resp) => {
    const sql =  'SELECT * FROM `rep_lab` rp INNER JOIN `tabla` t ON rp.orden = t.orden';
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){
          //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_rep;
            let json = {id: result[0].id_rep, emp: result[0].emp, edm: result[0].edm, precio: result[0].precio,
                cdp: result[0].cdp, pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_rep == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_rep;
                    json = {id: result[i].id_rep, emp: result[i].emp, edm: result[i].edm, precio: result[i].precio,
                        cdp: result[i].cdp, pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
        }else{
            resp.send("9");
        }
          con.end();
        });
    });
});
app.get('/rep_lab/:id', (req, resp) => {
    const orden = req.params.id;
    const sql =  "SELECT * FROM `rep_lab` rp INNER JOIN `tabla` t ON rp.orden = t.orden AND rp.orden = '" + orden + "';";
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){
          //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_rep;
            let json = {id: result[0].id_rep, emp: result[0].emp, edm: result[0].edm, precio: result[0].precio,
                cdp: result[0].cdp, pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_rep == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_rep;
                    json = {id: result[i].id_rep, emp: result[i].emp, edm: result[i].edm, precio: result[i].precio,
                        cdp: result[i].cdp, pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
        }else{
            resp.send("7");
        }
          con.end();
        });
    });    
});
app.get('/rep_lab/emp/:id',(req, resp) => {
    const emp = req.params.id;
    const sql =  "SELECT * FROM `rep_lab` rp INNER JOIN `tabla` t ON rp.orden = t.orden AND rp.emp = '" + emp + "';";
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){
          //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_rep;
            let json = {id: result[0].id_rep, emp: result[0].emp, edm: result[0].edm, precio: result[0].precio,
                cdp: result[0].cdp, pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_rep == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_rep;
                    json = {id: result[i].id_rep, emp: result[i].emp, edm: result[i].edm, precio: result[i].precio,
                        cdp: result[i].cdp, pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
        }else{
            resp.send("8");
        }
          con.end();
        });
    });
});
app.post('/rep_lab', (req, resp) => {
    let data = req.body;
    data.precio = parseInt(data.precio);
    data.plazomax = parseInt(data.plazomax);
    data['conf'] = false;
    const nof = parseInt(data.noferta.split('-')[1]);
    let sql =  `INSERT INTO rep_lab (emp, edm, precio, cdp, pmde, orden, fecha, confirmado) values ('${data.empresa}', '${data.entrega}', ${data.precio}, '${data.formadepago}', '${data.plazomax}', '${data.noferta}', '${data.fecha}', ${data.conf});
    UPDATE last SET num = ${nof};`;
    for(let t of data.tabla){
        t.cant = parseInt(t.cant);
        t.unit = parseInt(t.unit);
        const ins = `INSERT INTO tabla (cant, descr, punit, orden) VALUES (${t.cant}, '${t.desc}', ${t.unit}, '${data.noferta}');`;
        sql += ins;
    }
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }
          con.end();
        });
    });

    resp.send("1");
});

//end of region



//region ASISTENCIA TECNICA

app.get('/asis_tec', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `asis_tec`';
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }else if(result.length != 0)
                resp.send(result);
            else
                resp.send("9");
          con.end();
        });
    });
});

app.get('/asis_tec/:id', (req, resp) =>{
    const orden = req.params.id;
    const con = connectionSQL();
    const sql =  "SELECT * FROM `asis_tec` WHERE orden LIKE '" +orden+"';";
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }else if(result.length != 0)
                resp.send(result);
            else
                resp.send("7");
          con.end();
        });
    });
});

app.get('/asis_tec/emp/:id', (req, resp) => {
    const emp = req.params.id;
    const con = connectionSQL();
    const sql =  "SELECT * FROM `asis_tec` WHERE emp LIKE '" +emp+"';";
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }else if(result.length != 0)
                resp.send(result);
            else
                resp.send("8");
          con.end();
        });
    });
});

app.post('/asis_tec', (req, resp) => {
    const data = req.body;
    data.precio = parseInt(data.precio);
    const nof = parseInt(data.noferta.split('-')[1]);
    data['conf'] = false;


    const con = connectionSQL();
    const sql =  `INSERT INTO asis_tec (emp, tipo, precio, fdp, det, orden, fecha, confirmado) values ('${data.empresa}', '${data.asistencia}', ${data.precio}, '${data.formadepago}', '${data.detalle}', '${data.noferta}', '${data.fecha}', ${data.conf});
    UPDATE last SET num = ${nof};`;
    con.connect(function(err) {
        if (err){
            console.error(err);
            resp.send('0');
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send('0');
          }
          con.end();
        });
    });

    resp.send("1");
}),

//end of region


//region VENTA DE PRODUCTOS

app.get('/venta_prod', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `venta_prod` vp INNER JOIN `tabla` t ON vp.orden = t.orden';
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){
          //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_venta;
            let json = {id: result[0].id_venta, emp: result[0].emp, edm: result[0].edm, precio: result[0].precio,
                cdp: result[0].cdp, pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_venta == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_venta;
                    json = {id: result[i].id_venta, emp: result[i].emp, edm: result[i].edm, precio: result[i].precio,
                        cdp: result[i].cdp, pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
        }else{
            resp.send("9");
        }
          con.end();
        });
    });
});

app.get('/venta_prod/:id', (req, resp) => {
    const orden = req.params.id;
    const con = connectionSQL();
    const sql =  "SELECT * FROM `venta_prod` vp INNER JOIN `tabla` t ON vp.orden = t.orden AND vp.orden = '"+orden+"';";
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){
          //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_venta;
            let json = {id: result[0].id_venta, emp: result[0].emp, edm: result[0].edm, precio: result[0].precio,
                cdp: result[0].cdp, pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_venta == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_venta;
                    json = {id: result[i].id_venta, emp: result[i].emp, edm: result[i].edm, precio: result[i].precio,
                        cdp: result[i].cdp, pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
        }else{
            resp.send("7");
        }
          con.end();
        });
    });
});

app.get('/venta_prod/emp/:id', (req, resp) => {
    const emp = req.params.id;
    const con = connectionSQL();
    const sql =  "SELECT * FROM `venta_prod` vp INNER JOIN `tabla` t ON vp.orden = t.orden AND vp.emp = '"+emp+"';";
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }else if(result.length != 0){
          //PARSING FROM RESULTS TO TABLE
            let index = result[0].id_venta;
            let json = {id: result[0].id_venta, emp: result[0].emp, edm: result[0].edm, precio: result[0].precio,
                cdp: result[0].cdp, pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, conf: result[0].Confirmado, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
            let arr = []
            for(let i = 1; i < result.length; i++){
                if(result[i].id_venta == index)
                    json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
                else{
                    arr.push(json);
                    index = result[i].id_venta;
                    json = {id: result[i].id_venta, emp: result[i].emp, edm: result[i].edm, precio: result[i].precio,
                        cdp: result[i].cdp, pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, conf: result[i].Confirmado, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
                }
                if(i == result.length -1)
                    arr.push(json);
                
            }
            if(result.length == 1) 
                arr.push(json);

            resp.send(arr);
        }else{
            resp.send("8");
        }
          con.end();
        });
    });
});

app.post('/venta_prod', (req, resp) => {
    let data = req.body;
    data.precio = parseInt(data.precio);
    data.plazomax = parseInt(data.plazomax);
    data['conf'] = false;
    const nof = parseInt(data.noferta.split('-')[1]);
    let sql =  `INSERT INTO venta_prod (emp, edm, precio, cdp, pmde, orden, fecha, confirmado) values ('${data.empresa}', '${data.entrega}', ${data.precio}, '${data.formadepago}', '${data.plazomax}', '${data.noferta}', '${data.fecha}', ${data.conf});
    UPDATE last SET num = ${nof};`;
    for(let t of data.tabla){
        t.cant = parseInt(t.cant);
        t.unit = parseInt(t.unit);
        const ins = `INSERT INTO tabla (cant, descr, punit, orden) VALUES (${t.cant}, '${t.desc}', ${t.unit}, '${data.noferta}');`;
        sql += ins;
    }
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }
          con.end();
        });
    });

    resp.send("1");
});

//end of region


//region EMPRESAS
app.post('/emp', (req, resp) => {
    let emp = req.body;
    emp.cuit = parseInt(emp.cuit);
    emp.tel = parseInt(emp.tel);
    emp.telb = parseInt(emp.telb);
    emp.telcom = parseInt(emp.telcom);

    const con = connectionSQL();

    const sql =  "SELECT * FROM `emp` WHERE `emp` = '" + emp.emp  + "';";
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
            console.error(err);
            resp.send("0");
          }else if(result.length == 0){
            const qry = `INSERT into emp (emp, cuit, dir, loc, web, telcom, rub, descrub, cont, mail, tel, contb, mailb, telb) 
            VALUES ('${emp.emp}', ${emp.cuit}, '${emp.dir}', '${emp.loc}', '${emp.web}', ${emp.telcom}, '${emp.rub}', '${emp.esp}', '${emp.cont}', '${emp.mail}', ${emp.tel}, '${emp.contb}', '${emp.mailb}', ${emp.telb});`;
            con.query(qry, function (err, result, fields) {
                if (err){
                    console.error(err);
                    resp.send("0");
                }else{
                    console.log("INSERT DONE");
                    resp.send("1");
                }
            });
          }else{
            resp.send("2");
          }
          con.end();
        });
    });
});

app.get('/emp', (req, resp) => {
    const sql = "SELECT * FROM `emp`";
    const con = connectionSQL();
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }else
                resp.send(result);
          con.end();
        });
    });
});

app.get('/emp/:id', (req, resp) => {
    const con = connectionSQL();
    
    let sql = "SELECT * FROM `emp` WHERE";
    if(parseInt(req.params.id))
        sql += " `cuit` = " + req.params.id;
    else
        sql += " `emp` = '" + req.params.id +"';";
    

    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }else if(result.length != 0)
                resp.send(result);
            else
                resp.send("9");
          con.end();
        });
    });
});
//end of region




app.get('/last', (req, resp) => {
    const con = connectionSQL();
    const sql = 'SELECT * FROM last';
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }
          resp.send(result);
          con.end();
        });
    });
});


app.get('/tabla', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `tabla`';
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }else{
                resp.send(result);
            }
          con.end();
        });
    });
});

app.get('/tabla/:id', (req, resp) => {
    const orden = req.params.id;
    const con = connectionSQL();
    const sql =  "SELECT * FROM `tabla` WHERE orden LIKE '"+ orden +"';";
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }else if (result.length != 0){
                resp.send(result);
            }else{
                resp.send("10");
            }
          con.end();
        });
    });
});


// region NOTIFICATIONS

app.get('/notif', (req, resp) => {
    resp.send(notifications);
});

app.get('/notif/:id', (req, resp) => {
    resp.send(notifications[req.params.id]);
});
// end of region


app.listen(3030, () => console.log('Server running'));
