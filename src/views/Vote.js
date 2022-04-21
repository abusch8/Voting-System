import "./Vote.css";
import Header from "../components/Header";
import Poll from "../components/Poll";
import Confirmation from "../components/Confirmation";
import { Accordion, Card } from "react-bootstrap";
import { useState } from "react";

const polls = [
  {
    title: "Trump vs. Biden",
    endDate: new Date("2021-02-04"),
    choices: ["Trump", "Biden"],
    result: null
  },
  { 
    title: "Brown vs. Cortez Masto",
    endDate: new Date("2023-01-08"),
    choices: [ "test1", "test2"],
    result: null },
  { 
    title: "Georgia Senate - Democratic Primary",
    endDate: new Date("2020-08-24"),
    choices: ["Warnock", "Johnson-Shealey"],
    result: null
  },
  {
    title: "Georgia Senate - Republican Primary",
    endDate: new Date("2022-05-25"),
    choices: ["Walker", "Black", "King", "Saddler", "Clark", "McColumn"],
    result: null
  }
];

export default function Vote() {
  const [show, setShow] = useState(false);

  return (
    <>
      <Header />
      <Confirmation show={show} setShow={setShow} />
      <div className="div__vote-selection">
        <Card>
          <Card.Body className="card-body__vote-selection">
            <Accordion>{polls.map((item, index) => Poll(item, index, setShow))}</Accordion>
          </Card.Body>
        </Card>
      </div>
    </>
  );
}