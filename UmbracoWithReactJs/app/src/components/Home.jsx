import React from 'react';
import PropTypes from 'prop-types';
import Hero from './Hero';
import Content from "./Content";
import FooterHome from "./FooterHome";

const Home = (props) => {
    return (
        <div>
            <Hero {...props.Hero}/>
            <section className="section section">
                <Content content={props.Content}/>
            </section>
            <FooterHome {...props.FooterHomeModel}/>
        </div>

    )
};

Home.propTypes = {
    Hero: PropTypes.object.isRequired,
    FooterHomeModel: PropTypes.object.isRequired,
    Content: PropTypes.string.isRequired
};

export default Home;