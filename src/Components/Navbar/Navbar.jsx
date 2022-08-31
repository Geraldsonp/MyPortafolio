import React, { useState } from "react";
import logo from "../../Assets/logo.png";
import { HiOutlineMail } from "react-icons/hi";
import { BsFillPersonLinesFill } from "react-icons/bs";
import { Link } from "react-scroll";
import { FaBars, FaTimes, FaGithub, FaLinkedin, FaFacebook } from "react-icons/fa";
import MenuItem from "./MenuItem";

export const Navbar = () => {
  const [nav, setNav] = useState(false);
  const handleClick = () => setNav(!nav);

  return (
    <div
      className=' fixed w-full 
                    h-[80px] flex 
                    justify-between 
                    items-center px-4 
                    bg-[#0a192f]
                     text-gray-300'>
      <div>
        <img src={logo} alt='Logo image' style={{ width: "60px" }} />
      </div>
      {/* Menu */}
      <div>
        <ul className='hidden md:flex'>
          <MenuItem goto='home'>Home</MenuItem>
          <MenuItem goto='about'>About</MenuItem>
          <MenuItem goto='skills'>Skills</MenuItem>
          <MenuItem goto='work'>Work</MenuItem>
          <MenuItem goto='contact'>Contact</MenuItem>
        </ul>
      </div>
      {/* Hamburger */}
      <div onClick={handleClick} className='md:hidden z-10 cursor-pointer'>
        {!nav ? <FaBars /> : <FaTimes />}
      </div>

      {/* Mobile Menu */}
      <ul
        className={
          !nav
            ? "hidden"
            : "absolute top-0 left-0 w-full h-screen bg-[#0a192f] flex flex-col justify-center items-center "
        }>
        <li className='py-6 text-4xl btn'>
          <Link onClick={handleClick} activeClass='active' to='home' smooth={true} duration={500}>
            Home
          </Link>
        </li>
        <li className='py-6 text-4xl btn'>
          <Link onClick={handleClick} activeClass='active' to='about' smooth={true} duration={500}>
            About
          </Link>
        </li>
        <li className='py-6 text-4xl btn'>
          <Link onClick={handleClick} activeClass='active' to='skills' smooth={true} duration={500}>
            Skills
          </Link>
        </li>
        <li className='py-6 text-4xl btn'>
          <Link onClick={handleClick} activeClass='active' to='work' smooth={true} duration={500}>
            Work
          </Link>
        </li>
        <li className='py-6 text-4xl btn'>
          <Link onClick={handleClick} activeClass='active' to='contact' smooth={true} duration={500}>
            Contact
          </Link>
        </li>
      </ul>

      {/* Social Icons */}

      <div className='hidden lg:flex fixed flex-col top-[35%] left-0'>
        <ul>
          <li className='w-[160px] h-[60px] flex justify-between items-center ml-[-100px] hover:ml-[-10px] duration-300 bg-blue-600'>
            <a
              target='_blank'
              href='https://www.linkedin.com/in/geraldson-perez-0a7726185/'
              className='flex justify-between items-center w-full text-gray-300'>
              LinkedIn <FaLinkedin size={30} />
            </a>
          </li>
          <li className='w-[160px] h-[60px] flex justify-between items-center ml-[-100px] hover:ml-[-10px] duration-300 bg-[#333333]'>
            <a
              target='_blank'
              href='https://github.com/Geraldsonp'
              className='flex justify-between items-center w-full text-gray-300'>
              GitHub <FaGithub size={30} />
            </a>
          </li>
          <li className='w-[160px] h-[60px] flex justify-between items-center ml-[-100px] hover:ml-[-10px] duration-300 bg-[#6fc2b0]'>
            <a
              target='_blank'
              href='mailto:Geraldson.a.p@gmail.com'
              className='flex justify-between items-center w-full text-gray-300'>
              Email Me <HiOutlineMail size={30} />
            </a>
          </li>
          <li className='w-[160px] h-[60px] flex justify-between items-center ml-[-100px] hover:ml-[-10px] duration-300 bg-[#565f69]'>
            <a
              target='_blank'
              href='https://drive.google.com/file/d/1l8if5YON5s6ZBipBIHgNEuAO4bizoW7b/view'
              className='flex justify-between items-center w-full text-gray-300'>
              CV <BsFillPersonLinesFill size={30} />
            </a>
          </li>
        </ul>
      </div>
    </div>
  );
};
