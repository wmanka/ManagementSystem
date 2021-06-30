// Ext.define("ClientApp.store.Reservation", {
//   extend: "Ext.data.Store",

//   alias: "store.reservation",

//   model: "ClientApp.model.Reservation",

//   data: {
//     items: [
//       { code: "ABC", price: "5", currency: "PLN" },
//       { code: "DEF", price: "50", currency: "PLN" },
//     ],
//   },

//   proxy: {
//     type: "memory",
//     reader: {
//       type: "json",
//       rootProperty: "items",
//     },
//   },
// });

Ext.define("ClientApp.store.Reservation", {
  extend: "Ext.data.Store",

  alias: "store.reservation",

  model: "ClientApp.model.Reservation",

  proxy: {
    type: "jsonp",
    url: "http://localhost:57977/api/reservations",
  },
  callbackKey: "callback",
  callback: function (data) {
    console.log("callback" + data);
  },
  reader: {
    type: "json",
  },
  autoload: true,
});

// Ext.define("ClientApp.store.Reservation", {
//   extend: "Ext.data.Store",
//   alias: "store.reservation",
//   model: "ClientApp.model.Reservation",

//   proxy: {
//     type: "ajax",
//     url: "http://localhost:57977/api/reservations",
//   },
//   reader: {
//     type: "json",
//   },
// });
