import React, { useEffect } from "react";
import { Container, Grid } from "semantic-ui-react";

// const Seats = [
//     {
//         name: "A",
//         seats: [
//             {
//                 id: "A1",
//                 row: "A",
//                 number: 1,
//                 rowIndex: 1,
//                 columnIndex: 0
//             },
//             {
//                 id: "A2",
//                 row: "A",
//                 number: 2,
//                 rowIndex: 1,
//                 columnIndex: 1
//             },
//             {
//                 id: "A3",
//                 row: "A",
//                 number: 3,
//                 rowIndex: 1,
//                 columnIndex: 2
//             },
//             {
//                 id: "A4",
//                 row: "A",
//                 number: 4,
//                 rowIndex: 1,
//                 columnIndex: 3
//             },
//             {
//                 id: "A5",
//                 row: "A",
//                 number: 5,
//                 rowIndex: 1,
//                 columnIndex: 4
//             },
//             {
//                 id: "A6",
//                 row: "A",
//                 number: 6,
//                 rowIndex: 1,
//                 columnIndex: 5
//             },
//             {
//                 id: "A7",
//                 row: "A",
//                 number: 7,
//                 rowIndex: 1,
//                 columnIndex: 6
//             },
//             {
//                 id: "A8",
//                 row: "A",
//                 number: 8,
//                 rowIndex: 1,
//                 columnIndex: 7
//             },
//             {
//                 id: "A9",
//                 row: "A",
//                 number: 9,
//                 rowIndex: 1,
//                 columnIndex: 8
//             },
//             {
//                 id: "A10",
//                 row: "A",
//                 number: 10,
//                 rowIndex: 1,
//                 columnIndex: 9
//             },
//             {
//                 id: "A11",
//                 row: "A",
//                 number: 11,
//                 rowIndex: 1,
//                 columnIndex: 10
//             },
//             {
//                 id: "A12",
//                 row: "A",
//                 number: 12,
//                 rowIndex: 1,
//                 columnIndex: 11
//             },
//         ]
//     },
//     {
//         name: "B",
//         seats: [
//             {
//                 id: "B1",
//                 row: "B",
//                 number: 1,
//                 rowIndex: 2,
//                 columnIndex: 0
//             },
//             {
//                 id: "B2",
//                 row: "B",
//                 number: 2,
//                 rowIndex: 2,
//                 columnIndex: 1
//             },
//             {
//                 id: "B3",
//                 row: "B",
//                 number: 3,
//                 rowIndex: 2,
//                 columnIndex: 2
//             },
//             {
//                 id: "B4",
//                 row: "B",
//                 number: 4,
//                 rowIndex: 2,
//                 columnIndex: 3
//             },
//             {
//                 id: "B5",
//                 row: "B",
//                 number: 5,
//                 rowIndex: 2,
//                 columnIndex: 4
//             },
//             {
//                 id: "B6",
//                 row: "B",
//                 number: 6,
//                 rowIndex: 2,
//                 columnIndex: 5
//             },
//             {
//                 id: "B7",
//                 row: "B",
//                 number: 7,
//                 rowIndex: 2,
//                 columnIndex: 6
//             },
//             {
//                 id: "B8",
//                 row: "B",
//                 number: 8,
//                 rowIndex: 2,
//                 columnIndex: 7
//             },
//             {
//                 id: "B9",
//                 row: "B",
//                 number: 9,
//                 rowIndex: 2,
//                 columnIndex: 8
//             },
//             {
//                 id: "B10",
//                 row: "B",
//                 number: 10,
//                 rowIndex: 2,
//                 columnIndex: 9
//             },
//             {
//                 id: "B11",
//                 row: "B",
//                 number: 11,
//                 rowIndex: 2,
//                 columnIndex: 10
//             },
//             {
//                 id: "B12",
//                 row: "B",
//                 number: 12,
//                 rowIndex: 2,
//                 columnIndex: 11
//             },
//         ]
//     },
//     {
//         name: "0",
//         seats: []
//     },
//     {
//         name: "C",
//         seats: [
//             {
//                 id: "C1",
//                 row: "C",
//                 number: 1,
//                 rowIndex: 3,
//                 columnIndex: 0
//             },
//             {
//                 id: "C2",
//                 row: "C",
//                 number: 2,
//                 rowIndex: 3,
//                 columnIndex: 1
//             },
//             {
//                 id: "C3",
//                 row: "C",
//                 number: 3,
//                 rowIndex: 3,
//                 columnIndex: 2
//             },
//             {
//                 id: "C4",
//                 row: "C",
//                 number: 4,
//                 rowIndex: 3,
//                 columnIndex: 3
//             },
//             {
//                 id: "C5",
//                 row: "C",
//                 number: 5,
//                 rowIndex: 3,
//                 columnIndex: 4
//             },
//             {
//                 id: "C6",
//                 row: "C",
//                 number: 6,
//                 rowIndex: 3,
//                 columnIndex: 5
//             },
//             {
//                 id: "C0",
//                 row: "C",
//                 number: 0,
//                 rowIndex: 3,
//                 columnIndex: 6
//             },
//             {
//                 id: "C7",
//                 row: "C",
//                 number: 7,
//                 rowIndex: 3,
//                 columnIndex: 7
//             },
//             {
//                 id: "C8",
//                 row: "C",
//                 number: 8,
//                 rowIndex: 3,
//                 columnIndex: 8
//             },
//             {
//                 id: "C9",
//                 row: "C",
//                 number: 9,
//                 rowIndex: 3,
//                 columnIndex: 9
//             },
//             {
//                 id: "C10",
//                 row: "C",
//                 number: 10,
//                 rowIndex: 3,
//                 columnIndex: 10
//             },
//             {
//                 id: "C11",
//                 row: "C",
//                 number: 11,
//                 rowIndex: 3,
//                 columnIndex: 11
//             },
//         ]
//     }, {
//         name: "D",
//         seats: [
//             {
//                 id: "D1",
//                 row: "D",
//                 number: 1,
//                 rowIndex: 4,
//                 columnIndex: 0
//             },
//             {
//                 id: "D2",
//                 row: "D",
//                 number: 2,
//                 rowIndex: 4,
//                 columnIndex: 1
//             },
//             {
//                 id: "D3",
//                 row: "D",
//                 number: 3,
//                 rowIndex: 4,
//                 columnIndex: 2
//             },
//             {
//                 id: "D4",
//                 row: "D",
//                 number: 4,
//                 rowIndex: 4,
//                 columnIndex: 3
//             },
//             {
//                 id: "D5",
//                 row: "D",
//                 number: 5,
//                 rowIndex: 4,
//                 columnIndex: 4
//             },
//             {
//                 id: "D6",
//                 row: "D",
//                 number: 6,
//                 rowIndex: 4,
//                 columnIndex: 5
//             },
//             {
//                 id: "D7",
//                 row: "D",
//                 number: 7,
//                 rowIndex: 4,
//                 columnIndex: 7
//             },
//             {
//                 id: "D8",
//                 row: "D",
//                 number: 8,
//                 rowIndex: 4,
//                 columnIndex: 8
//             },
//             {
//                 id: "D9",
//                 row: "D",
//                 number: 9,
//                 rowIndex: 4,
//                 columnIndex: 9
//             },
//             {
//                 id: "D10",
//                 row: "D",
//                 number: 10,
//                 rowIndex: 4,
//                 columnIndex: 10
//             },
//         ]
//     }
// ]

