import React from "react";
import { Link } from "react-scroll";

export default function MenuItem({ children, goto }) {
  return (
    <li className='btnEffect'>
      <Link activeClass='active' to={goto} smooth={true} duration={500}>
        {children}
      </Link>
    </li>
  );
}
