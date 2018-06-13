import React from 'react';
import PropTypes from 'prop-types';
import SeactionHeader from "./SeactionHeader";
import Person from "./Person";

const People = (props) => {
    const {people} = props;
    const displayPeople = (person, key) => {
        return <Person key={key} {...person}/>
    };
    return (
        <main>
            <SeactionHeader pageTitle={props.pageTitle}/>
            <section className="section">
                <div className="container">
                    <div className="employee-grid">
                        {people.map(displayPeople)}
                    </div>
                </div>

            </section>
        </main>
    )
};

People.propTypes = {
    people: PropTypes.array.isRequired
};

export default People;