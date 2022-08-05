import React from "react";
import { HiArrowNarrowRight } from "react-icons/hi";
import { Link } from "react-scroll";

const Home = () => {
  return (
    <div name='home' className='w-full h-screen bg-[#0a192f]'>
      {/* Container */}
      <div className=' max-w-[1000px] mx-auto px-8 flex flex-col justify-center h-full'>
        <p className='text-[#39e8ff]'>Hi, My name is </p>
        <h1 className=' text-4xl sm:text-7xl font-bold text-[#ccd6f6]'>Geraldson Perez</h1>
        <h2 className=' text-4xl sm:text-7xl font-bold text-[#a3bfd9]'>I'm a Full Stack Developer.</h2>
        <p className='text-[#a3bfd9] py-4 max-w-[700px]'>
          I'm specializing in building exceptional digital experiences. Currently, Im focused on building resposive
          full-stack web applications.
        </p>
        <div>
          <Link activeClass='active' to='work' smooth={true} duration={500}>
            <button
              className='text-white group border-2 px-6 py-3 my-2 flex items-center
            hover:bg-[#39e8ff] hover:border-[#2ba3e0]'>
              View Work
              <span className='group-hover:rotate-90 duration-300'>
                <HiArrowNarrowRight className='ml-3 ' />
              </span>
            </button>
          </Link>
        </div>
      </div>
    </div>
  );
};

export default Home;
